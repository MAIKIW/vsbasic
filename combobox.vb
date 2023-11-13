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
            MsgBox("ตัวเลือกสินค้าไม่ถูกต้อง")
        End If
        txtpdname.Text = pdname
        txtpdprice.Text = pdprice.ToString("#,0.00")
        txtpdqty.Focus()
    End Sub
