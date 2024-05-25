<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kaze_Calc
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
        Me.lblTtl = New System.Windows.Forms.Label
        Me.txtAns = New System.Windows.Forms.TextBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdSub = New System.Windows.Forms.Button
        Me.txtA = New System.Windows.Forms.TextBox
        Me.txtB = New System.Windows.Forms.TextBox
        Me.txtS = New System.Windows.Forms.TextBox
        Me.cmdClr = New System.Windows.Forms.Button
        Me.cmdClrAll = New System.Windows.Forms.Button
        Me.cmdFact = New System.Windows.Forms.Button
        Me.cmdExp = New System.Windows.Forms.Button
        Me.cmdAnsA = New System.Windows.Forms.Button
        Me.cmdAnsX = New System.Windows.Forms.Button
        Me.cmdSq = New System.Windows.Forms.Button
        Me.cmdCu = New System.Windows.Forms.Button
        Me.cmdSqrt = New System.Windows.Forms.Button
        Me.cmdCurt = New System.Windows.Forms.Button
        Me.cmdMul = New System.Windows.Forms.Button
        Me.cmdDiv = New System.Windows.Forms.Button
        Me.cmdAnsB = New System.Windows.Forms.Button
        Me.KAZE = New System.Windows.Forms.Label
        Me.cmdSin = New System.Windows.Forms.Button
        Me.cmdCos = New System.Windows.Forms.Button
        Me.cmdLog = New System.Windows.Forms.Button
        Me.cmdLn = New System.Windows.Forms.Button
        Me.txtX = New System.Windows.Forms.TextBox
        Me.cmdExp10 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTtl
        '
        Me.lblTtl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTtl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTtl.Font = New System.Drawing.Font("Mistral", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtl.ForeColor = System.Drawing.Color.Maroon
        Me.lblTtl.Location = New System.Drawing.Point(139, 9)
        Me.lblTtl.Name = "lblTtl"
        Me.lblTtl.Size = New System.Drawing.Size(275, 35)
        Me.lblTtl.TabIndex = 0
        Me.lblTtl.Text = "Simple Scientific Calculator"
        '
        'txtAns
        '
        Me.txtAns.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAns.Cursor = System.Windows.Forms.Cursors.No
        Me.txtAns.Enabled = False
        Me.txtAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAns.Location = New System.Drawing.Point(139, 158)
        Me.txtAns.Multiline = True
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(408, 70)
        Me.txtAns.TabIndex = 20
        Me.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(139, 104)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(40, 40)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSub
        '
        Me.cmdSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSub.Location = New System.Drawing.Point(190, 104)
        Me.cmdSub.Name = "cmdSub"
        Me.cmdSub.Size = New System.Drawing.Size(40, 40)
        Me.cmdSub.TabIndex = 4
        Me.cmdSub.Text = "-"
        Me.cmdSub.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(79, 63)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(170, 35)
        Me.txtA.TabIndex = 1
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(301, 63)
        Me.txtB.Name = "txtB"
        Me.txtB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtB.Size = New System.Drawing.Size(170, 35)
        Me.txtB.TabIndex = 2
        '
        'txtS
        '
        Me.txtS.BackColor = System.Drawing.Color.LightCyan
        Me.txtS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtS.Enabled = False
        Me.txtS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS.ForeColor = System.Drawing.SystemColors.Window
        Me.txtS.Location = New System.Drawing.Point(255, 63)
        Me.txtS.Name = "txtS"
        Me.txtS.ReadOnly = True
        Me.txtS.Size = New System.Drawing.Size(40, 37)
        Me.txtS.TabIndex = 19
        Me.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdClr
        '
        Me.cmdClr.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdClr.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.cmdClr.Location = New System.Drawing.Point(9, 174)
        Me.cmdClr.Name = "cmdClr"
        Me.cmdClr.Size = New System.Drawing.Size(39, 40)
        Me.cmdClr.TabIndex = 7
        Me.cmdClr.Text = "clear"
        Me.cmdClr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClr.UseVisualStyleBackColor = False
        '
        'cmdClrAll
        '
        Me.cmdClrAll.BackColor = System.Drawing.Color.LightGray
        Me.cmdClrAll.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.cmdClrAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClrAll.Location = New System.Drawing.Point(3, 158)
        Me.cmdClrAll.Name = "cmdClrAll"
        Me.cmdClrAll.Size = New System.Drawing.Size(130, 70)
        Me.cmdClrAll.TabIndex = 8
        Me.cmdClrAll.Text = "ALL"
        Me.cmdClrAll.UseVisualStyleBackColor = False
        '
        'cmdFact
        '
        Me.cmdFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFact.Location = New System.Drawing.Point(255, 307)
        Me.cmdFact.Name = "cmdFact"
        Me.cmdFact.Size = New System.Drawing.Size(40, 40)
        Me.cmdFact.TabIndex = 12
        Me.cmdFact.Text = "X!"
        Me.cmdFact.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExp.Location = New System.Drawing.Point(255, 353)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(40, 40)
        Me.cmdExp.TabIndex = 15
        Me.cmdExp.Text = "1/X"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdAnsA
        '
        Me.cmdAnsA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnsA.Location = New System.Drawing.Point(3, 63)
        Me.cmdAnsA.Name = "cmdAnsA"
        Me.cmdAnsA.Size = New System.Drawing.Size(70, 35)
        Me.cmdAnsA.TabIndex = 16
        Me.cmdAnsA.Text = "Ans →"
        Me.cmdAnsA.UseVisualStyleBackColor = True
        '
        'cmdAnsX
        '
        Me.cmdAnsX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnsX.Location = New System.Drawing.Point(117, 244)
        Me.cmdAnsX.Name = "cmdAnsX"
        Me.cmdAnsX.Size = New System.Drawing.Size(70, 35)
        Me.cmdAnsX.TabIndex = 18
        Me.cmdAnsX.Text = "Ans →"
        Me.cmdAnsX.UseVisualStyleBackColor = True
        '
        'cmdSq
        '
        Me.cmdSq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSq.Location = New System.Drawing.Point(209, 307)
        Me.cmdSq.Name = "cmdSq"
        Me.cmdSq.Size = New System.Drawing.Size(40, 40)
        Me.cmdSq.TabIndex = 10
        Me.cmdSq.Text = "X²"
        Me.cmdSq.UseVisualStyleBackColor = True
        '
        'cmdCu
        '
        Me.cmdCu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCu.Location = New System.Drawing.Point(301, 307)
        Me.cmdCu.Name = "cmdCu"
        Me.cmdCu.Size = New System.Drawing.Size(40, 40)
        Me.cmdCu.TabIndex = 11
        Me.cmdCu.Text = "X³"
        Me.cmdCu.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSqrt.Location = New System.Drawing.Point(209, 353)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(40, 40)
        Me.cmdSqrt.TabIndex = 13
        Me.cmdSqrt.Text = "√X"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdCurt
        '
        Me.cmdCurt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCurt.Location = New System.Drawing.Point(301, 353)
        Me.cmdCurt.Name = "cmdCurt"
        Me.cmdCurt.Size = New System.Drawing.Size(40, 40)
        Me.cmdCurt.TabIndex = 14
        Me.cmdCurt.Text = "³√X"
        Me.cmdCurt.UseVisualStyleBackColor = True
        '
        'cmdMul
        '
        Me.cmdMul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMul.Location = New System.Drawing.Point(374, 104)
        Me.cmdMul.Name = "cmdMul"
        Me.cmdMul.Size = New System.Drawing.Size(40, 40)
        Me.cmdMul.TabIndex = 5
        Me.cmdMul.Text = "×"
        Me.cmdMul.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        Me.cmdDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiv.Location = New System.Drawing.Point(321, 104)
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.Size = New System.Drawing.Size(40, 40)
        Me.cmdDiv.TabIndex = 6
        Me.cmdDiv.Text = "÷"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdAnsB
        '
        Me.cmdAnsB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnsB.Location = New System.Drawing.Point(477, 63)
        Me.cmdAnsB.Name = "cmdAnsB"
        Me.cmdAnsB.Size = New System.Drawing.Size(70, 35)
        Me.cmdAnsB.TabIndex = 17
        Me.cmdAnsB.Text = "← Ans"
        Me.cmdAnsB.UseVisualStyleBackColor = True
        '
        'KAZE
        '
        Me.KAZE.AutoSize = True
        Me.KAZE.BackColor = System.Drawing.Color.Azure
        Me.KAZE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KAZE.Font = New System.Drawing.Font("Monotype Corsiva", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KAZE.ForeColor = System.Drawing.Color.Purple
        Me.KAZE.Location = New System.Drawing.Point(490, 535)
        Me.KAZE.Name = "KAZE"
        Me.KAZE.Size = New System.Drawing.Size(62, 15)
        Me.KAZE.TabIndex = 21
        Me.KAZE.Text = "KAZE here ;)"
        '
        'cmdSin
        '
        Me.cmdSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSin.Location = New System.Drawing.Point(209, 450)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(60, 30)
        Me.cmdSin.TabIndex = 22
        Me.cmdSin.Text = "sinX"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCos.Location = New System.Drawing.Point(281, 450)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(60, 30)
        Me.cmdCos.TabIndex = 23
        Me.cmdCos.Text = "cosX"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.Location = New System.Drawing.Point(281, 486)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(60, 30)
        Me.cmdLog.TabIndex = 25
        Me.cmdLog.Text = "logX"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdLn
        '
        Me.cmdLn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLn.Location = New System.Drawing.Point(209, 486)
        Me.cmdLn.Name = "cmdLn"
        Me.cmdLn.Size = New System.Drawing.Size(60, 30)
        Me.cmdLn.TabIndex = 24
        Me.cmdLn.Text = "lnX"
        Me.cmdLn.UseVisualStyleBackColor = True
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(190, 244)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(170, 35)
        Me.txtX.TabIndex = 9
        Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdExp10
        '
        Me.cmdExp10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExp10.Location = New System.Drawing.Point(246, 399)
        Me.cmdExp10.Name = "cmdExp10"
        Me.cmdExp10.Size = New System.Drawing.Size(58, 40)
        Me.cmdExp10.TabIndex = 26
        Me.cmdExp10.Text = "10^X"
        Me.cmdExp10.UseVisualStyleBackColor = True
        '
        'Kaze_Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(550, 551)
        Me.Controls.Add(Me.cmdExp10)
        Me.Controls.Add(Me.cmdLog)
        Me.Controls.Add(Me.cmdLn)
        Me.Controls.Add(Me.cmdCos)
        Me.Controls.Add(Me.cmdSin)
        Me.Controls.Add(Me.KAZE)
        Me.Controls.Add(Me.cmdAnsB)
        Me.Controls.Add(Me.cmdMul)
        Me.Controls.Add(Me.cmdDiv)
        Me.Controls.Add(Me.cmdCurt)
        Me.Controls.Add(Me.cmdSqrt)
        Me.Controls.Add(Me.cmdCu)
        Me.Controls.Add(Me.cmdSq)
        Me.Controls.Add(Me.cmdAnsX)
        Me.Controls.Add(Me.cmdAnsA)
        Me.Controls.Add(Me.cmdExp)
        Me.Controls.Add(Me.cmdFact)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.cmdClr)
        Me.Controls.Add(Me.cmdClrAll)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.cmdSub)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.lblTtl)
        Me.Name = "Kaze_Calc"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTtl As System.Windows.Forms.Label
    Friend WithEvents txtAns As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdSub As System.Windows.Forms.Button
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtS As System.Windows.Forms.TextBox
    Friend WithEvents cmdClr As System.Windows.Forms.Button
    Friend WithEvents cmdClrAll As System.Windows.Forms.Button
    Friend WithEvents cmdFact As System.Windows.Forms.Button
    Friend WithEvents cmdExp As System.Windows.Forms.Button
    Friend WithEvents cmdAnsA As System.Windows.Forms.Button
    Friend WithEvents cmdAnsX As System.Windows.Forms.Button
    Friend WithEvents cmdSq As System.Windows.Forms.Button
    Friend WithEvents cmdCu As System.Windows.Forms.Button
    Friend WithEvents cmdSqrt As System.Windows.Forms.Button
    Friend WithEvents cmdCurt As System.Windows.Forms.Button
    Friend WithEvents cmdMul As System.Windows.Forms.Button
    Friend WithEvents cmdDiv As System.Windows.Forms.Button
    Friend WithEvents cmdAnsB As System.Windows.Forms.Button
    Friend WithEvents KAZE As System.Windows.Forms.Label
    Friend WithEvents cmdSin As System.Windows.Forms.Button
    Friend WithEvents cmdCos As System.Windows.Forms.Button
    Friend WithEvents cmdLog As System.Windows.Forms.Button
    Friend WithEvents cmdLn As System.Windows.Forms.Button
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents cmdExp10 As System.Windows.Forms.Button

End Class
