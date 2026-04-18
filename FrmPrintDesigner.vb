Public Class FrmPrintDesigner

    Private Sub FrmPrintDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ఫామ్ లోడ్ అయినప్పుడు సెట్టింగ్స్ లోడ్ చేయాలి
        LoadSettings()
        RenderPreview()

        ' గ్రిడ్ సెట్టింగ్స్
        dgvSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSettings.AllowUserToAddRows = False
        dgvSettings.RowHeadersVisible = False
    End Sub

    Private Sub LoadSettings()
        Try
            ' అన్ని కాలమ్స్ ని సెలెక్ట్ చేయడం
            Dim dt = DatabaseHelper.ExecuteQuery("SELECT * FROM print_settings ORDER BY label_y ASC")

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                SetupDefaultSettings()
                dt = DatabaseHelper.ExecuteQuery("SELECT * FROM print_settings ORDER BY label_y ASC")
            End If

            dgvSettings.DataSource = dt

            ' కాలమ్ హెడర్స్ పేరు మార్చడం (మీరు అడిగిన క్రమంలో)
            If dgvSettings.Columns.Count > 0 Then
                dgvSettings.Columns("field_name").HeaderText = "Field Name"
                dgvSettings.Columns("label_text").HeaderText = "Label Name"
                dgvSettings.Columns("label_x").HeaderText = "Label X"
                dgvSettings.Columns("label_y").HeaderText = "Label Y"
                dgvSettings.Columns("label_font_size").HeaderText = "L-Size"
                dgvSettings.Columns("label_is_bold").HeaderText = "L-Bold"
                dgvSettings.Columns("label_is_visible").HeaderText = "L-Vis"
                dgvSettings.Columns("data_x").HeaderText = "Data X"
                dgvSettings.Columns("data_y").HeaderText = "Data Y"
                dgvSettings.Columns("data_font_size").HeaderText = "D-Size"
                dgvSettings.Columns("data_is_bold").HeaderText = "D-Bold"
                dgvSettings.Columns("data_is_visible").HeaderText = "D-Vis"
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    ' డిఫాల్ట్ సెట్టింగ్స్ - మొదటిసారి సాఫ్ట్‌వేర్ రన్ అయినప్పుడు ఇవి యాడ్ అవుతాయి
    Private Sub SetupDefaultSettings()
        ' ఫీల్డ్ పేరు, Label X, Label Y, Data X, Data Y, ఫాంట్ సైజు
        Dim defaults As New List(Of Tuple(Of String, Integer, Integer, Integer, Integer, Integer)) From {
        Tuple.Create("company_name", 300, 40, 300, 40, 18),
        Tuple.Create("slip_number", 60, 120, 220, 120, 10),
        Tuple.Create("weighment_type", 300, 120, 420, 120, 10),
        Tuple.Create("vehicle_number", 60, 155, 220, 155, 10),
        Tuple.Create("vehicle_type", 480, 155, 600, 155, 10),
        Tuple.Create("party_name", 60, 185, 220, 185, 10),
        Tuple.Create("sub_party", 480, 185, 600, 185, 10),
        Tuple.Create("phone", 60, 215, 220, 215, 10),
        Tuple.Create("material_name", 480, 215, 600, 215, 10),
        Tuple.Create("gross_weight", 60, 270, 200, 270, 12),
        Tuple.Create("gross_time", 300, 270, 380, 270, 10),
        Tuple.Create("tare_weight", 60, 300, 200, 300, 12),
        Tuple.Create("tare_time", 300, 300, 380, 300, 10),
        Tuple.Create("net_weight", 60, 330, 200, 330, 12),
        Tuple.Create("deduction_weight", 60, 360, 200, 360, 12),
        Tuple.Create("final_weight", 60, 390, 200, 390, 12),
        Tuple.Create("rate", 450, 360, 550, 360, 12),
        Tuple.Create("amount", 450, 390, 550, 390, 12),
        Tuple.Create("charges", 60, 430, 150, 430, 12),
        Tuple.Create("payment_mode", 480, 430, 600, 430, 12)
    }

        For Each item In defaults
            DatabaseHelper.ExecuteNonQuery(
            "INSERT OR IGNORE INTO print_settings (field_name, label_x, label_y, data_x, data_y, label_font_size, data_font_size) " &
            "VALUES (@fn, @lx, @ly, @dx, @dy, @lfs, @dfs)",
            New Dictionary(Of String, Object) From {
                {"@fn", item.Item1}, {"@lx", item.Item2}, {"@ly", item.Item3},
                {"@dx", item.Item4}, {"@dy", item.Item5}, {"@lfs", item.Item6}, {"@dfs", item.Item6}
            })
        Next
    End Sub





    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Try
            For Each row As DataGridViewRow In dgvSettings.Rows
                If Not row.IsNewRow Then
                    Dim fName As String = If(row.Cells("field_name").Value?.ToString(), "")
                    If fName <> "" Then
                        DatabaseHelper.ExecuteNonQuery(
                        "INSERT OR REPLACE INTO print_settings (field_name, label_text, label_x, label_y, label_font_size, label_is_bold, label_is_visible, data_x, data_y, data_font_size, data_is_bold, data_is_visible) " &
                        "VALUES (@fn, @lt, @lx, @ly, @lfs, @lb, @lv, @dx, @dy, @dfs, @db, @dv)",
                        New Dictionary(Of String, Object) From {
                            {"@fn", fName}, {"@lt", row.Cells("label_text").Value},
                            {"@lx", row.Cells("label_x").Value}, {"@ly", row.Cells("label_y").Value},
                            {"@lfs", row.Cells("label_font_size").Value}, {"@lb", row.Cells("label_is_bold").Value}, {"@lv", row.Cells("label_is_visible").Value},
                            {"@dx", row.Cells("data_x").Value}, {"@dy", row.Cells("data_y").Value},
                            {"@dfs", row.Cells("data_font_size").Value}, {"@db", row.Cells("data_is_bold").Value}, {"@dv", row.Cells("data_is_visible").Value}
                        })
                    End If
                End If
            Next
            RenderPreview()
            MsgBox("Print Design Saved! ✅")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub RenderPreview()
        Try
            Dim bmp As New Bitmap(827, 1169)
            Dim g = Graphics.FromImage(bmp)
            g.Clear(Color.White)

            Dim printData As New Dictionary(Of String, String) From {
            {"company_name", "MY COMPANY NAME"},
            {"slip_number", "0001"},
            {"vehicle_number", "TS12AS2361"},
            {"party_name", "Vijay Kumar"},
            {"material_name", "Sand"},
            {"gross_weight", "1500 KG"},
            {"tare_weight", "1000 KG"},
            {"final_weight", "500 KG"},
            {"amount", "5000.00"},
            {"payment_mode", "CASH"}
        }

            Dim dt = DatabaseHelper.ExecuteQuery("SELECT * FROM print_settings")

            For Each row As DataRow In dt.Rows
                Dim fieldName As String = row("field_name").ToString()

                ' --- Label Printing ---
                If Convert.ToInt32(row("label_is_visible")) = 1 Then
                    Dim lx As Integer = Convert.ToInt32(row("label_x"))
                    Dim ly As Integer = Convert.ToInt32(row("label_y"))
                    Dim lSize As Integer = Convert.ToInt32(row("label_font_size"))
                    Dim lBold As Boolean = Convert.ToInt32(row("label_is_bold")) = 1

                    Dim lFont As New Font("Segoe UI", lSize, If(lBold, FontStyle.Bold, FontStyle.Regular))
                    g.DrawString(fieldName & " : ", lFont, Brushes.Black, lx, ly)
                End If

                ' --- Data Printing ---
                If Convert.ToInt32(row("data_is_visible")) = 1 Then
                    Dim dx As Integer = Convert.ToInt32(row("data_x"))
                    Dim dy As Integer = Convert.ToInt32(row("data_y"))
                    Dim dSize As Integer = Convert.ToInt32(row("data_font_size"))
                    Dim dBold As Boolean = Convert.ToInt32(row("data_is_bold")) = 1

                    Dim dFont As New Font("Segoe UI", dSize, If(dBold, FontStyle.Bold, FontStyle.Regular))
                    Dim value As String = If(printData.ContainsKey(fieldName), printData(fieldName), "---")
                    g.DrawString(value, dFont, Brushes.Black, dx, dy)
                End If
            Next

            picPreview.Image = bmp
            g.Dispose()
        Catch ex As Exception
            Debug.WriteLine("Preview Error: " & ex.Message)
        End Try
    End Sub



    Private Sub dgvSettings_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSettings.CellValueChanged
        RenderPreview()
    End Sub

    Private Sub dgvSettings_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSettings.CellLeave
        RenderPreview()
    End Sub

    Private Sub dgvSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSettings.KeyDown
        RenderPreview()
    End Sub
End Class
