Public Class Form3
    Dim ax, ay, bx, by, cx, cy, result, m1, m2, m3 As Decimal
    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        lbl_5.Text = ""
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
        lbl_5.Text = ""
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
                result = ((ax - bx) ^ 2 + (ay - by) ^ 2) ^ (1 / 2)
                txt_1.Text = result
                lbl_1.Visible = False
                lbl_2.Visible = False
                lbl_3.Visible = True
                lbl_4.Visible = True
                lbl_5.Visible = True
                lbl_5.Text = "وحدة طولية"
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
                m1 = ((ax - bx) ^ 2 + (ay - by) ^ 2) ^ (1 / 2)
                m2 = ((bx - cx) ^ 2 + (by - cy) ^ 2) ^ (1 / 2)
                m3 = ((ax - cx) ^ 2 + (ay - cy) ^ 2) ^ (1 / 2)
                If m3 = m1 + m2 Then
                    txt_1.Text = ""
                    txt_1.Visible = False
                    lbl_1.Text = "النقاط"
                    lbl_1.Visible = True
                    lbl_2.Visible = True
                    lbl_3.Visible = False
                    lbl_4.Visible = False
                    lbl_5.Visible = False
                    lbl_5.Text = ""

                ElseIf m2 = m1 + m3 Then
                    txt_1.Text = ""
                    txt_1.Visible = False
                    lbl_1.Text = "النقاط"
                    lbl_1.Visible = True
                    lbl_2.Visible = True
                    lbl_3.Visible = False
                    lbl_4.Visible = False
                    lbl_5.Visible = False
                    lbl_5.Text = ""

                ElseIf m1 = m2 + m3 Then
                    txt_1.Text = ""
                    txt_1.Visible = False
                    lbl_1.Text = "النقاط"
                    lbl_1.Visible = True
                    lbl_2.Visible = True
                    lbl_3.Visible = False
                    lbl_4.Visible = False
                    lbl_5.Visible = False
                    lbl_5.Text = ""

                ElseIf m1 > m2 And m1 > m3 Then
                    If m1 ^ 2 > m2 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث منفرج"
                    End If
                    If m1 ^ 2 < m2 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث حاد"
                    End If
                    If m1 ^ 2 = m2 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث قائم"
                    End If




                ElseIf m2 > m3 And m2 > m1 Then
                    If m2 ^ 2 > m1 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث منفرج"
                    End If
                    If m2 ^ 2 < m1 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث حاد"
                    End If
                    If m2 ^ 2 = m1 ^ 2 + m3 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث قائم"
                    End If



                ElseIf m3 > m1 And m3 > m2 Then
                    If m3 ^ 2 > m1 ^ 2 + m2 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث منفرج"
                    End If
                    If m3 ^ 2 < m1 ^ 2 + m2 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث حاد"
                    End If
                    If m3 ^ 2 = m1 ^ 2 + m2 ^ 2 Then
                        txt_1.Text = ""
                        txt_1.Visible = False
                        lbl_1.Text = "النقاط ليست"
                        lbl_1.Visible = True
                        lbl_2.Visible = True
                        lbl_3.Visible = False
                        lbl_4.Visible = False
                        lbl_5.Visible = True
                        lbl_5.Text = "النقاط لمثلث قائم"
                    End If
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