Public Class Form4
    Dim ax, ay, bx, by, m1, m2, cx, cy As Decimal
    Private Sub Form4_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Visible = True
    End Sub

    Private Sub tmr_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_1.Tick
        lbl_4.Text = Now
    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Try
            If rad_1.Checked = True Then
                ax = Decimal.Parse(txt_ax.Text)
                ay = Decimal.Parse(txt_ay.Text)
                bx = Decimal.Parse(txt_bx.Text)
                by = Decimal.Parse(txt_by.Text)
                cx = (ax + bx) / 2
                cy = (ay + by) / 2
                txt_cx.Text = cx
                txt_cy.Text = cy
                lbl_2.Text = "نقطة التنصيف"
                lbl_2.Visible = True
                txt_cx.Visible = True
                txt_cy.Visible = True
                lbl_c.Visible = True
                lbl_c1.Visible = True
                lbl_c2.Visible = True
                lbl_c3.Visible = True
                lbl_1.Visible = False
                lbl_3.Visible = False
                lbl_3.Text = ""
            End If

            If rad_2.Checked = True Then
                ax = Decimal.Parse(txt_ax.Text)
                ay = Decimal.Parse(txt_ay.Text)
                bx = Decimal.Parse(txt_bx.Text)
                by = Decimal.Parse(txt_by.Text)
                m1 = Decimal.Parse(txt_m1.Text)
                m2 = Decimal.Parse(txt_m2.Text)
                cx = ((m1 * bx) + (m2 * ax)) / (m1 + m2)
                cy = ((m1 * by) + (m2 * ay)) / (m1 + m2)
                txt_cx.Text = cx
                txt_cy.Text = cy
                lbl_2.Text = "نقطة التقسيم"
                lbl_2.Visible = True
                txt_cx.Visible = True
                txt_cy.Visible = True
                lbl_c.Visible = True
                lbl_c1.Visible = True
                lbl_c2.Visible = True
                lbl_c3.Visible = True
                lbl_1.Visible = False
                lbl_3.Visible = True
                If m1 < 0 Or m2 < 0 Then
                    lbl_3.Text = "التقسيم من الخارج"
                ElseIf m1 > 0 And m2 > 0 Then
                    lbl_3.Text = "التقسيم من الداخل"
                ElseIf m1 < 0 And m2 < 0 Then
                    lbl_3.Text = "التقسيم من الداخل"
                End If
            End If
        Catch
            lbl_1.Visible = True
            lbl_2.Visible = False
            lbl_3.Visible = False
            lbl_4.Visible = False
            lbl_c.Visible = False
            lbl_c1.Visible = False
            lbl_c2.Visible = False
            lbl_c3.Visible = False
            txt_cx.Visible = False
            txt_cy.Visible = False
        End Try
    End Sub

    Private Sub rad_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_1.CheckedChanged
        lbl_m1.Visible = False
        lbl_m2.Visible = False
        txt_m1.Visible = False
        txt_m2.Visible = False
        txt_ax.Text = ""
        txt_ay.Text = ""
        txt_bx.Text = ""
        txt_by.Text = ""
        txt_cx.Text = ""
        txt_cy.Text = ""
        lbl_1.Visible = False
        lbl_2.Visible = False
        lbl_c.Visible = False
        lbl_c1.Visible = False
        lbl_c2.Visible = False
        lbl_c3.Visible = False
        txt_cx.Visible = False
        txt_cy.Visible = False
        lbl_3.Text = ""
        lbl_2.Text = ""
    End Sub

    Private Sub rad_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_2.CheckedChanged
        lbl_m1.Visible = True
        lbl_m2.Visible = True
        txt_m1.Visible = True
        txt_m2.Visible = True
        txt_ax.Text = ""
        txt_ay.Text = ""
        txt_bx.Text = ""
        txt_by.Text = ""
        txt_cx.Text = ""
        txt_cy.Text = ""
        lbl_1.Visible = False
        lbl_2.Visible = False
        lbl_c.Visible = False
        lbl_c1.Visible = False
        lbl_c2.Visible = False
        lbl_c3.Visible = False
        txt_cx.Visible = False
        txt_cy.Visible = False
        lbl_3.Text = ""
        lbl_2.Text = ""
    End Sub
End Class