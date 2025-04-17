Public Class Form1

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Me.Visible = False
        Form2.Show()
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        Me.Visible = False
        Form3.Show()
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        Me.Visible = False
        Form4.Show()
    End Sub
End Class
