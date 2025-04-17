Public Class Form2
    Dim ax, ay, bx, by, cx, cy, result, m1, m2 As Decimal
    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Visible = True
    End Sub

    Private Sub tmr_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_1.Tick
        lbl_6.Text = Now
    End Sub

    Private Sub rad_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_1.CheckedChanged
        lbl_1.Visible = False
        lbl_1.Text = ""
        lbl_2.Visible = False
        lbl_3.Visible = False
        lbl_4.Visible = False
        lbl_5.Visible = False
        txt_1.Visible = False
        txt_1.Text = ""
        lbl_c.Visible = False
        lbl_c1.Visible = False
        lbl_c2.Visible = False
        lbl_c3.Visible = False
        txt_cx.Visible = False
        txt_cy.Visible = False
        txt_ax.Text = ""
        txt_ay.Text = ""
        txt_bx.Text = ""
        txt_by.Text = ""
        txt_cx.Text = ""
        txt_cy.Text = ""
    End Sub

    Private Sub rad_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_2.CheckedChanged
        lbl_1.Visible = False
        lbl_1.Text = ""
        lbl_2.Visible = False
        lbl_3.Visible = False
        lbl_4.Visible = False
        lbl_5.Visible = False
        txt_1.Visible = False
        txt_1.Text = ""
        lbl_c.Visible = True
        lbl_c1.Visible = True
        lbl_c2.Visible = True
        lbl_c3.Visible = True
        txt_cx.Visible = True
        txt_cy.Visible = True
        txt_ax.Text = ""
        txt_ay.Text = ""
        txt_bx.Text = ""
        txt_by.Text = ""
        txt_cx.Text = ""
        txt_cy.Text = ""
    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click

        Try
            If rad_1.Checked = True Then
                ax = Decimal.Parse(txt_ax.Text)
                ay = Decimal.Parse(txt_ay.Text)
                bx = Decimal.Parse(txt_bx.Text)
                by = Decimal.Parse(txt_by.Text)
                result = (ay - by) / (ax - bx)
                txt_1.Text = result
                lbl_1.Visible = False
                lbl_2.Visible = False
                lbl_3.Visible = True
                lbl_4.Visible = True
                lbl_5.Visible = False
                txt_1.Visible = True
                Me.lst_1.Items.Add(result)
            End If

            If rad_2.Checked = True Then
                ax = Decimal.Parse(txt_ax.Text)
                ay = Decimal.Parse(txt_ay.Text)
                bx = Decimal.Parse(txt_bx.Text)
                by = Decimal.Parse(txt_by.Text)
                cx = Decimal.Parse(txt_cx.Text)
                cy = Decimal.Parse(txt_cy.Text)
                m1 = (ay - by) / (ax - bx)
                m2 = (by - cy) / (bx - cx)
                If m1 = m2 Then
                    result = m1
                    txt_1.Text = result
                    txt_1.Visible = True
                    lbl_1.Text = "النقاط"
                    lbl_1.Visible = True
                    lbl_2.Visible = True
                    lbl_3.Visible = True
                    lbl_4.Visible = True
                    lbl_5.Visible = False
                Else
                    txt_1.Text = ""
                    lbl_1.Visible = True
                    lbl_1.Text = "النقاط ليست"
                    lbl_2.Visible = True
                    lbl_3.Visible = False
                    lbl_4.Visible = False
                    lbl_5.Visible = True
                    txt_1.Visible = False
                End If
            End If
        Catch
            lbl_1.Visible = True
            lbl_1.Text = "العملية خاطئة"
            lbl_2.Visible = False
            lbl_3.Visible = False
            lbl_4.Visible = False
            lbl_5.Visible = False
            txt_1.Visible = False
            txt_1.Text = ""
        End Try
    End Sub
End Class