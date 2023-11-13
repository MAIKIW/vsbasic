If DataGridView1.Rows.Count > 1 Then
            If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                If MessageBox.Show("คุณต้องการลบข้อมูล" & DataGridView1.CurrentRow.Cells(0).Value, "ระวัง", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

                    ssum = 0
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        ssum += DataGridView1.Rows(i).Cells(4).Value
                    Next
                    svat = ssum * 7 / 100
                    stotal = ssum + svat

                    lblsum.Text = ssum.ToString("#,0.00")
                    lblvat.Text = svat.ToString("#,0.00")
                End If
            Else
                MessageBox.Show("คุณยังไม่ได้เลือกข้อมูล", "ระวัง", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("ไม่มีข้อมูลในตาราง", "ระวัง", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
    End Sub
