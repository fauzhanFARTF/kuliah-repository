Imports System.Data.OleDb
Public Class DataBarang
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Dim sql As String
    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DbpenjualanD.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub Tampilgrid()
        da = New OleDbDataAdapter("select * from tbbarang", conn)
        ds = New DataSet
        da.Fill(ds, "tbbarang")
        DataGridView1.DataSource = ds.Tables("tbbarang")
    End Sub
    Sub Tampildata()
        TextBox2.Text = rd.Item(1)
        ComboBox1.Text = rd.Item(2)
        TextBox3.Text = rd.Item(3)
        TextBox4.Text = rd.Item(4)
    End Sub
    Sub Textmati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
    End Sub
    Sub Kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilgrid()
        Call Textmati()
        Me.btnadd.Enabled = True
        Me.btnsave.Enabled = False
        Me.btnedit.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btncancel.Enabled = False
        Me.btndelete.Enabled = False
        Me.btnexit.Enabled = True
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
        Menuutama.Show()
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Call Kosong()
        Call TextHidup()
        Me.TextBox1.Focus()
        Me.btnadd.Enabled = False
        Me.btnsave.Enabled = True
        Me.btnedit.Enabled = False
        Me.btnupdate.Enabled = False
        Me.btncancel.Enabled = True
        Me.btndelete.Enabled = False
        Me.btnexit.Enabled = True
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            'MsgBox("Data belum lengkap, Pastikan Semua Form Terisi")
            MessageBox.Show("Data belum lengkap, Pastikan Semua Form Terisi", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Call koneksi()
            Try
                Dim simpan As String = "insert into tbbarang (kdbarang, nmbarang, satuan, jumlah, harga) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                cmd = New OleDbCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Baru Berhasil Disimpan", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Data Baru Gagal dilakukan / Data Sudah Ada", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            Call Tampilgrid()
            DataGridView1.Refresh()
            Call koneksi()
            Call Kosong()
            Call Textmati()
            Me.btnadd.Enabled = True
            Me.btnsave.Enabled = False
            Me.btnedit.Enabled = False
            Me.btnupdate.Enabled = False
            Me.btncancel.Enabled = False
            Me.btndelete.Enabled = False
            Me.btnexit.Enabled = True
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call TextHidup()
        TextBox1.Enabled = False
        btnadd.Enabled = False
        btnsave.Enabled = False
        btnedit.Enabled = False
        btnupdate.Enabled = True
        btncancel.Enabled = True
        btndelete.Enabled = True
        btnexit.Enabled = True
    End Sub
    Private Sub txtkodebarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub

    Private Sub txtkodebarang_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        str = "SELECT * FROM tbbarang where kdbarang ='" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox2.Text = rd.GetString(1)
                ComboBox1.Text = rd.GetString(2)
                TextBox3.Text = rd.GetValue(3)
                TextBox4.Text = rd.GetValue(4)
                Textmati()
                Me.btnadd.Enabled = False
                Me.btnsave.Enabled = False
                Me.btnedit.Enabled = True
                Me.btnupdate.Enabled = False
                Me.btncancel.Enabled = False
                Me.btndelete.Enabled = False
                Me.btnexit.Enabled = True
            End While
        Finally
            rd.Close()
        End Try
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 25
        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub
    

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If MessageBox.Show("Do You Want Save Again ?", "SUKSES", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            sql = "update tbbarang set nmbarang = '" & TextBox2.Text & "', satuan = '" & ComboBox1.Text & "', jumlah ='" & TextBox3.Text & "', harga = '" & TextBox4.Text & "' where kdbarang = '" & TextBox1.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Refresh()

            Call Textmati()
            Call Kosong()
            Me.btnadd.Enabled = True
            Me.btnsave.Enabled = False
            Me.btnedit.Enabled = False
            Me.btnupdate.Enabled = False
            Me.btncancel.Enabled = False
            Me.btndelete.Enabled = False
            Me.btnexit.Enabled = True
            DataGridView1.Refresh()
            Call Tampilgrid()
        End If
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Call Kosong()
        Call Textmati()
        Me.btnadd.Enabled = True
        Me.btnsave.Enabled = False
        Me.btnedit.Enabled = True
        Me.btnupdate.Enabled = False
        Me.btncancel.Enabled = False
        Me.btndelete.Enabled = False
        Me.btnexit.Enabled = True
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode belum diisi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tbbarang where kdbarang='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call Tampilgrid()
                Call Kosong()
                Me.btnadd.Enabled = True
                Me.btnsave.Enabled = False
                Me.btnedit.Enabled = False
                Me.btnupdate.Enabled = False
                Me.btncancel.Enabled = False
                Me.btndelete.Enabled = False
                Me.btnexit.Enabled = True
            Else
                Call Textmati()
            End If
        End If
    End Sub
    Private Sub cmbsatuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        ComboBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub
    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub
    Private Sub txtharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 10
        If e.KeyChar = Chr(13) Then btnsave.Focus()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.SelectedCells(0).RowIndex
        TextBox1.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.Rows(i).Cells(1).Value.ToString()
        ComboBox1.Text = DataGridView1.Rows(i).Cells(2).Value.ToString()
        TextBox3.Text = DataGridView1.Rows(i).Cells(3).Value.ToString()
        TextBox4.Text = DataGridView1.Rows(i).Cells(4).Value.ToString()
        TextBox1.Focus()
    End Sub

