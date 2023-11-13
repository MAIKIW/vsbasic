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
                lblvat.Text = svat.ToString("#,0.00")
                lbltotal.Text = stotal.ToString("#,0.00")

                txtpdqty.Focus()
                txtpdqty.Text = ""
            Else
                MessageBox.Show("กรุณาใส่จำนวนสินค้าให้ถูกต้อง", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("คุณยังไม่ได้เลือกรายการสินค้า!", "ระวัง", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
