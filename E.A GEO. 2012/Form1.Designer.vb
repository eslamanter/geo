<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.btn_1 = New System.Windows.Forms.Button
        Me.pct_1 = New System.Windows.Forms.PictureBox
        Me.btn_2 = New System.Windows.Forms.Button
        Me.btn_3 = New System.Windows.Forms.Button
        Me.grb_1 = New System.Windows.Forms.GroupBox
        Me.lbl_2 = New System.Windows.Forms.Label
        Me.grb_2 = New System.Windows.Forms.GroupBox
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_1.SuspendLayout()
        Me.grb_2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_1
        '
        Me.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.Location = New System.Drawing.Point(12, 9)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(225, 72)
        Me.lbl_1.TabIndex = 2
        Me.lbl_1.Text = "GEO 2012"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.Black
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(6, 18)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(225, 40)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "الميل"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'pct_1
        '
        Me.pct_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_1.Image = CType(resources.GetObject("pct_1.Image"), System.Drawing.Image)
        Me.pct_1.Location = New System.Drawing.Point(12, 84)
        Me.pct_1.Name = "pct_1"
        Me.pct_1.Size = New System.Drawing.Size(225, 170)
        Me.pct_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_1.TabIndex = 2
        Me.pct_1.TabStop = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.Black
        Me.btn_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(6, 64)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(225, 40)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "البعد بين نقطتين"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.Black
        Me.btn_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(6, 110)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(225, 40)
        Me.btn_3.TabIndex = 2
        Me.btn_3.Text = "تقسيم قطعة مستقيمة"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'grb_1
        '
        Me.grb_1.Controls.Add(Me.btn_1)
        Me.grb_1.Controls.Add(Me.btn_2)
        Me.grb_1.Controls.Add(Me.btn_3)
        Me.grb_1.ForeColor = System.Drawing.Color.White
        Me.grb_1.Location = New System.Drawing.Point(243, -6)
        Me.grb_1.Name = "grb_1"
        Me.grb_1.Size = New System.Drawing.Size(237, 155)
        Me.grb_1.TabIndex = 0
        Me.grb_1.TabStop = False
        '
        'lbl_2
        '
        Me.lbl_2.Font = New System.Drawing.Font("David", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lbl_2.Location = New System.Drawing.Point(6, 22)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(225, 56)
        Me.lbl_2.TabIndex = 0
        Me.lbl_2.Text = "Eslam Abdullah"
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grb_2
        '
        Me.grb_2.Controls.Add(Me.lbl_2)
        Me.grb_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_2.ForeColor = System.Drawing.Color.White
        Me.grb_2.Location = New System.Drawing.Point(243, 173)
        Me.grb_2.Name = "grb_2"
        Me.grb_2.Size = New System.Drawing.Size(237, 81)
        Me.grb_2.TabIndex = 1
        Me.grb_2.TabStop = False
        Me.grb_2.Text = "All rights reserved 2012"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(492, 266)
        Me.Controls.Add(Me.grb_2)
        Me.Controls.Add(Me.grb_1)
        Me.Controls.Add(Me.pct_1)
        Me.Controls.Add(Me.lbl_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.A GEO. 2012"
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_1.ResumeLayout(False)
        Me.grb_2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents pct_1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents grb_1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents grb_2 As System.Windows.Forms.GroupBox

End Class
