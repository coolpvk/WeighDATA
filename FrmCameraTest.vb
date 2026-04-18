Imports LibVLCSharp.Shared
Imports LibVLCSharp.WinForms

Public Class FrmCameraTest
    Private libVlc As LibVLC
    Private mp As MediaPlayer

    ' ఫామ్ లోడ్ అయినప్పుడు VLC ని సిద్ధం చేయడం
    Private Sub FrmCameraTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' VLC Core ని ఇనిషియలైజ్ చేయడం
            Core.Initialize()
            libVlc = New LibVLC()

            ' వీడియో వ్యూ సెట్టింగ్స్
            vViewTest.Dock = DockStyle.Fill
            vViewTest.Visible = True
        Catch ex As Exception
            MsgBox("VLC Init Error: " & ex.Message)
        End Try
    End Sub

    Public Sub StartStream(url As String)
        If String.IsNullOrWhiteSpace(url) Then
            MsgBox("URL missing!")
            Return
        End If

        Try
            ' 1. పాత ప్లేయర్ ఉంటే క్లీన్ చేయడం
            If mp IsNot Nothing Then
                mp.Stop()
                mp.Dispose()
            End If

            ' 2. MediaPlayer ని క్రియేట్ చేయడం
            mp = New MediaPlayer(libVlc)

            ' 3. వీడియో వ్యూ కి ప్లేయర్‌ను ముందుగా అసైన్ చేయడం (SURE-SHOT METHOD)
            vViewTest.MediaPlayer = mp

            ' 4. మీడియాను క్రియేట్ చేయడం
            Dim media = New Media(libVlc, url)

            ' 5. RTSP కోసం నెట్‌వర్క్ ఆప్షన్లు యాడ్ చేయడం (వీడియో లోడ్ అవ్వడానికి సహాయపడతాయి)
            media.AddOption(":network-caching=300")
            media.AddOption(":clock-jitter=0")
            media.AddOption(":clock-sync=0")

            ' 6. ప్లే చేయడం
            mp.Play(media)

            Debug.WriteLine("Playing RTSP: " & url)
        Catch ex As Exception
            MsgBox("Streaming Error: " & ex.Message)
        End Try
        Try
            mp = New MediaPlayer(libVlc)

            ' CORRECTED: Use New Uri(url) instead of just url
            Dim media = New Media(libVlc, New Uri(url))

            mp.Play(media)
            vViewTest.MediaPlayer = mp
        Catch ex As Exception
            MsgBox("Streaming Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmCameraTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            If mp IsNot Nothing Then
                mp.Stop()
                mp.Dispose()
            End If
            If libVlc IsNot Nothing Then
                libVlc.Dispose()
            End If
        Catch ex As Exception
            Debug.WriteLine("Dispose Error: " & ex.Message)
        End Try
    End Sub
End Class
