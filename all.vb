Public Class Form1
    Dim pdid, pdname As String
    Dim pdprice As Double
    Dim pdsum, ssum, svat, stotal As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(2).DefaultCellStyle.Format = "#,0.00"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "#,0.00"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,0.00"
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("คุณต้องการลบข้อมูล" &
                                   DataGridView1.CurrentRow.Cells(0).Value, "ระวัง", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    Next
                    svat = ssum + 7 / 100
                    stotal = ssum + svat

                    lblsum.Text = ssum.ToString("#,0.00")
                    lblvat.Text = svat.ToString("#,0,00")
                    lbltotal.Text = stotal.ToString("#,0.00")
                End If
            Else
                MessageBox.Show("คุณยังไม่ได้เลือกข้อมูล", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("ไม่มีข้อมูลในตาราง", "ระวัง", MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่", "ระวัง", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            end
        End If
    End Sub

    Dim pdqty As Integer

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cmbpdid.Text <> "" Then
            If Integer.TryParse(txtpdqty.Text, pdqty) Then
                pdsum = pdqty * pdprice

                Me.DataGridView1.Rows.Add(pdid, pdname, pdprice, pdqty, pdsum)

                ssum = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    ssum += DataGridView1.Rows(i).Cells(4).Value
                Next

                svat = ssum * 7 / 100
                stotal = ssum + svat
                lblsum.Text = ssum.ToString("#,0.00")
                lblvat.Text = svat.ToString("#,0,00")
                lbltotal.Text = stotal.ToString("#,0.00")

                txtpdqty.Focus()
                txtpdqty.Text = ""

            Else
                MessageBox.Show("กรุณาใส่จำนวนสินค้าให้ถูกต้อง", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("คุณยังไม่ได้เลือกสินค้า!", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmbpdid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpdid.SelectedIndexChanged
        If cmbpdid.Text = "001" Then
            pdid = "001"
            pdname = "ดินสอ"
            pdprice = 10.75
        ElseIf cmbpdid.Text = "002" Then
            pdid = "002"
            pdname = "ยางลบ"
            pdprice = 5.5
        ElseIf cmbpdid.Text = "003" Then
            pdid = "003"
            pdname = "ปากกา"
            pdprice = 13.75
        ElseIf cmbpdid.Text = "004" Then
            pdid = "004"
            pdname = "สมุด"
            pdprice = 15.0
        ElseIf cmbpdid.Text = "005" Then
            pdid = "005"
            pdname = "ไม้บรรทัด"
            pdprice = 7.0
        Else
            MsgBox("ตัวเลือกไม่ถูกต้อง")
        End If
        txtpdname.Text = pdname
        txtpdprice.Text = pdprice.ToString("#,0.00")
        txtpdqty.Focus()
    End Sub

    Private Sub Form1_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        cmbpdid.Text = ""
    End Sub
End Class
