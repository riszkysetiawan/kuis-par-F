<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnama = New TextBox()
        txtkategori = New TextBox()
        txtharga = New TextBox()
        txtstock = New TextBox()
        DataGridView1 = New DataGridView()
        btntambah = New Button()
        btnedit = New Button()
        btnhapus = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kategori Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(401, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(401, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Stock"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(150, 38)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(100, 23)
        txtnama.TabIndex = 4
        ' 
        ' txtkategori
        ' 
        txtkategori.Location = New Point(147, 90)
        txtkategori.Name = "txtkategori"
        txtkategori.Size = New Size(100, 23)
        txtkategori.TabIndex = 5
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(478, 44)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(100, 23)
        txtharga.TabIndex = 6
        ' 
        ' txtstock
        ' 
        txtstock.Location = New Point(478, 97)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(100, 23)
        txtstock.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(71, 203)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(576, 192)
        DataGridView1.TabIndex = 8
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(49, 143)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 9
        btntambah.Text = "Tamba Barang"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(172, 143)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(75, 23)
        btnedit.TabIndex = 10
        btnedit.Text = "Update Barang"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(290, 143)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 23)
        btnhapus.TabIndex = 11
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(DataGridView1)
        Controls.Add(txtstock)
        Controls.Add(txtharga)
        Controls.Add(txtkategori)
        Controls.Add(txtnama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
End Class
