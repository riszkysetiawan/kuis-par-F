Imports MySql.Data.MySqlClient

Public Class Form1
    ' Connection string untuk menghubungkan ke MySQL
    Dim connectionString As String = "server=localhost;user id=root;password=;database=kuisweek7"
    Dim connection As New MySqlConnection(connectionString)

    ' Method untuk membuka koneksi
    Private Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Method untuk menutup koneksi
    Private Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Method untuk load data barang ke DataGridView
    Private Sub LoadData()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM inventarisbarang"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Method untuk menambah barang baru
    Private Sub AddBarang()
        Try
            OpenConnection()
            Dim query As String = "INSERT INTO inventarisbarang (nama, kategori, harga, stok) VALUES (@nama, @kategori, @harga, @stok)"
            Dim cmd As New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            cmd.Parameters.AddWithValue("@kategori", txtkategori.Text)
            cmd.Parameters.AddWithValue("@harga", txtharga.Text)
            cmd.Parameters.AddWithValue("@stok", txtstock.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Barang berhasil ditambahkan")
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
    ' Method untuk menghapus barang (ID diambil dari DataGridView)
    Private Sub DeleteBarang()
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim id As Integer = DataGridView1.SelectedRows(0).Cells("id").Value
                OpenConnection()
                Dim query As String = "DELETE FROM inventarisbarang WHERE id = @id"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Barang berhasil dihapus")
                LoadData()
            Else
                MessageBox.Show("Pilih barang yang ingin dihapus")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Method untuk mengedit barang (ID diambil dari DataGridView)
    Private Sub UpdateBarang()
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim id As Integer = DataGridView1.SelectedRows(0).Cells("id").Value
                OpenConnection()
                Dim query As String = "UPDATE inventarisbarang SET nama=@nama, kategori=@kategori, harga=@harga, stok=@stok WHERE id=@id"
                Dim cmd As New MySqlCommand(query, connection)

                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", txtnama.Text)
                cmd.Parameters.AddWithValue("@kategori", txtkategori.Text)
                cmd.Parameters.AddWithValue("@harga", txtharga.Text)
                cmd.Parameters.AddWithValue("@stok", txtstock.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Barang berhasil diperbarui")
                LoadData()
            Else
                MessageBox.Show("Pilih barang yang ingin diedit")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Event handler untuk button tambah

    ' Form Load untuk menampilkan data
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        AddBarang()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        UpdateBarang()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        DeleteBarang()
    End Sub
End Class
