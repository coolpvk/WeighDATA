Imports System.Data.SQLite
Imports System.IO

Public Class DatabaseHelper

    Private Shared _dbPath As String = Path.Combine(
        Application.StartupPath, "WeighDATA.db")

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return $"Data Source={_dbPath};Version=3;"
        End Get
    End Property

    Public Shared Function GetConnection() As SQLiteConnection
        Dim conn As New SQLiteConnection(ConnectionString)
        conn.Open()
        Return conn
    End Function

    Public Shared Sub InitializeDatabase()
        Using conn = GetConnection()
            Dim cmd As New SQLiteCommand(conn)

            ' ── Companies ──────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS companies (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                name        TEXT NOT NULL,
                code        TEXT NOT NULL UNIQUE,
                address     TEXT,
                phone       TEXT,
                gst_number  TEXT,
                status      INTEGER DEFAULT 1,
                created_at  DATETIME DEFAULT CURRENT_TIMESTAMP
            )"
            cmd.ExecuteNonQuery()

            ' ── Branches ───────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS branches (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id  INTEGER NOT NULL,
                name        TEXT NOT NULL,
                code        TEXT NOT NULL,
                address     TEXT,
                phone       TEXT,
                status      INTEGER DEFAULT 1,
                FOREIGN KEY (company_id) REFERENCES companies(id)
            )"
            cmd.ExecuteNonQuery()

            ' ── Users ──────────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS users (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id  INTEGER,
                branch_id   INTEGER,
                username    TEXT NOT NULL UNIQUE,
                password    TEXT NOT NULL,
                name        TEXT,
                role        TEXT DEFAULT 'operator',
                status      INTEGER DEFAULT 1
            )"
            cmd.ExecuteNonQuery()

            ' ── Materials ──────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS materials (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id  INTEGER,
                name        TEXT NOT NULL,
                unit        TEXT DEFAULT 'MT',
                status      INTEGER DEFAULT 1
            )"
            cmd.ExecuteNonQuery()

            ' ── Parties ────────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS parties (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id  INTEGER,
                name        TEXT NOT NULL,
                type        TEXT DEFAULT 'both',
                phone       TEXT,
                address     TEXT,
                gst_number  TEXT,
                status      INTEGER DEFAULT 1
            )"
            cmd.ExecuteNonQuery()

            ' ── Vehicles ───────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS vehicles (
                id              INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id      INTEGER,
                vehicle_number  TEXT NOT NULL,
                type            TEXT DEFAULT 'third_party',
                owner_name      TEXT,
                capacity        REAL,
                status          INTEGER DEFAULT 1
            )"
            cmd.ExecuteNonQuery()

            ' ── Daily Rates ────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS daily_rates (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                company_id  INTEGER,
                material_id INTEGER,
                rate_date   DATE NOT NULL,
                rate        REAL NOT NULL,
                created_at  DATETIME DEFAULT CURRENT_TIMESTAMP
            )"
            cmd.ExecuteNonQuery()

            ' ── Weighments Table (Full Integration) ─────────────────────
            ' ── Weighments Table (Full Integration with IDs) ─────────────────────
            cmd.CommandText = "
CREATE TABLE IF NOT EXISTS weighments (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    company_id      INTEGER NOT NULL,
    branch_id       INTEGER NOT NULL,
    slip_number     TEXT NOT NULL,
    weigh_date      DATE NOT NULL,
    weigh_type      TEXT NOT NULL,
    vehicle_id      INTEGER,         -- Added Back
    vehicle_number  TEXT,
    vehicle_type_id  INTEGER,         -- Added
    vehicle_type    TEXT,
    party_id        INTEGER,         -- Added
    party_name      TEXT,
    mobile          TEXT,
    sub_party_id    INTEGER,         -- Added
    sub_party       TEXT,
    material_id     INTEGER,         -- Added
    material_name   TEXT,
    rate            REAL DEFAULT 0,
    amount          REAL DEFAULT 0,
    charges         REAL DEFAULT 0,
    payment_mode    TEXT,
    gross_weight    REAL DEFAULT 0,
    tare_weight     REAL DEFAULT 0,
    net_weight      REAL DEFAULT 0,
    deduction_weight REAL DEFAULT 0,
    gross_time      DATETIME,
    tare_time       DATETIME,
    status          TEXT DEFAULT 'pending',
    sync_status     TEXT DEFAULT 'pending',
    created_at      DATETIME DEFAULT CURRENT_TIMESTAMP
)"
            cmd.ExecuteNonQuery()


            ' ── System Settings Table (For Cameras, COM Ports, etc.) ───
            cmd.CommandText = "
                CREATE TABLE IF NOT EXISTS system_settings (
                setting_key     TEXT PRIMARY KEY,
                setting_value   TEXT
             )"
            cmd.ExecuteNonQuery()



            ' ── Vehicle Maintenance ────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS vehicle_maintenance (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                vehicle_id  INTEGER NOT NULL,
                service_date DATE NOT NULL,
                description TEXT,
                cost        REAL DEFAULT 0,
                odometer    REAL,
                next_due    DATE,
                sync_status TEXT DEFAULT 'pending'
            )"
            cmd.ExecuteNonQuery()

            ' ── Sync Queue ─────────────────────────────────────
            cmd.CommandText = "
            CREATE TABLE IF NOT EXISTS sync_queue (
                id          INTEGER PRIMARY KEY AUTOINCREMENT,
                table_name  TEXT NOT NULL,
                record_id   INTEGER NOT NULL,
                action      TEXT DEFAULT 'insert',
                created_at  DATETIME DEFAULT CURRENT_TIMESTAMP
            )"
            cmd.ExecuteNonQuery()

            ' ── Default admin user ─────────────────────────────
            cmd.CommandText = "
            INSERT OR IGNORE INTO users
                (username, password, name, role, company_id, branch_id)
            VALUES
                ('admin', 'admin123', 'Administrator', 'admin', 1, 1)"
            cmd.ExecuteNonQuery()

            ' ── Vehicle Types ───────────────────────────────────────
            cmd.CommandText = "
CREATE TABLE IF NOT EXISTS vehicle_types (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    company_id  INTEGER,
    name        TEXT NOT NULL UNIQUE,
    status      INTEGER DEFAULT 1
)"
            cmd.ExecuteNonQuery()

            ' ── Sub Parties ────────────────────────────────────────
            cmd.CommandText = "
CREATE TABLE IF NOT EXISTS sub_parties (
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    company_id  INTEGER,
    name        TEXT NOT NULL UNIQUE,
    status      INTEGER DEFAULT 1
)"
            cmd.ExecuteNonQuery()

            ' ── Print Settings Table ──────────────────────────────────────

            cmd.CommandText = "
CREATE TABLE IF NOT EXISTS print_settings (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    field_name      TEXT UNIQUE NOT NULL,
    label_text      TEXT,                -- లేబుల్ పేరు (ఉదా: Vehicle No :)
    label_x         INTEGER DEFAULT 50,
    label_y         INTEGER DEFAULT 50,
    label_font_size INTEGER DEFAULT 10,
    label_is_bold   INTEGER DEFAULT 0,
    label_is_visible INTEGER DEFAULT 1,
    data_x          INTEGER DEFAULT 180,
    data_y          INTEGER DEFAULT 50,
    data_font_size  INTEGER DEFAULT 10,
    data_is_bold    INTEGER DEFAULT 0,
    data_is_visible INTEGER DEFAULT 1
)"
            cmd.ExecuteNonQuery()


        End Using


    End Sub

    ' ── Execute Non Query ─────────────────────────────────────
    Public Shared Function ExecuteNonQuery(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing) As Integer
        Using conn = GetConnection()
            Using cmd As New SQLiteCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' ── Execute Query → DataTable ──────────────────────────────
    Public Shared Function ExecuteQuery(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing) As DataTable
        Using conn = GetConnection()
            Using cmd As New SQLiteCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Dim dt As New DataTable()
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                Return dt
            End Using
        End Using
    End Function

    ' ── Execute Scalar ─────────────────────────────────────────
    Public Shared Function ExecuteScalar(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing) As Object
        Using conn = GetConnection()
            Using cmd As New SQLiteCommand(sql, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function


    Public Shared Sub SaveSetting(key As String, value As String)
        Dim sql = "INSERT OR REPLACE INTO system_settings (setting_key, setting_value) VALUES (@k, @v)"
        ExecuteNonQuery(sql, New Dictionary(Of String, Object) From {{"@k", key}, {"@v", value}})
    End Sub

    Public Shared Function GetSetting(key As String, Optional defaultVal As String = "") As String
        Dim dt = ExecuteQuery("SELECT setting_value FROM system_settings WHERE setting_key=@k",
                New Dictionary(Of String, Object) From {{"@k", key}})
        Return If(dt.Rows.Count > 0, dt.Rows(0)(0).ToString(), defaultVal)
    End Function

    Public Shared Function EnsureMasterExists(tableName As String, columnName As String, value As String, companyId As Integer) As Integer
        If String.IsNullOrWhiteSpace(value) Then Return 0

        ' 1. ఇప్పటికే ఉందో లేదో చెక్ చేయి
        Dim sqlCheck = $"SELECT id FROM {tableName} WHERE {columnName}=@val AND company_id=@cid AND status=1"
        Dim dt = ExecuteQuery(sqlCheck, New Dictionary(Of String, Object) From {{"@val", value}, {"@cid", companyId}})

        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id")) ' ఇప్పటికే ఉంది, దాని ID ని రిటర్న్ చేయి
        Else
            ' 2. లేకపోతే కొత్తగా యాడ్ చేయి
            Dim sqlInsert = $"INSERT INTO {tableName} ({columnName}, company_id) VALUES (@val, @cid)"
            ExecuteNonQuery(sqlInsert, New Dictionary(Of String, Object) From {{"@val", value}, {"@cid", companyId}})

            ' కొత్తగా యాడ్ అయిన ID ని రిటర్న్ చేయి
            Return Convert.ToInt32(ExecuteScalar("SELECT last_insert_rowid()"))
        End If
    End Function

End Class