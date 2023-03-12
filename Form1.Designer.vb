<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picBoxMain = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblEnterValue = New System.Windows.Forms.Label()
        Me.txtBoxEnterValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBtnInches2Meters = New System.Windows.Forms.RadioButton()
        Me.radBtnMeters2Inches = New System.Windows.Forms.RadioButton()
        Me.lblReturnResult = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBoxMain
        '
        Me.picBoxMain.Image = Global.BuildingPlansConversion.My.Resources.Resources.building
        Me.picBoxMain.Location = New System.Drawing.Point(-1, 22)
        Me.picBoxMain.Name = "picBoxMain"
        Me.picBoxMain.Size = New System.Drawing.Size(304, 179)
        Me.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxMain.TabIndex = 0
        Me.picBoxMain.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(378, 54)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(236, 37)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Converter App"
        '
        'lblEnterValue
        '
        Me.lblEnterValue.AutoSize = True
        Me.lblEnterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterValue.ForeColor = System.Drawing.Color.White
        Me.lblEnterValue.Location = New System.Drawing.Point(365, 117)
        Me.lblEnterValue.Name = "lblEnterValue"
        Me.lblEnterValue.Size = New System.Drawing.Size(232, 58)
        Me.lblEnterValue.TabIndex = 2
        Me.lblEnterValue.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'txtBoxEnterValue
        '
        Me.txtBoxEnterValue.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtBoxEnterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEnterValue.ForeColor = System.Drawing.Color.White
        Me.txtBoxEnterValue.Location = New System.Drawing.Point(710, 129)
        Me.txtBoxEnterValue.Name = "txtBoxEnterValue"
        Me.txtBoxEnterValue.Size = New System.Drawing.Size(146, 35)
        Me.txtBoxEnterValue.TabIndex = 3
        Me.txtBoxEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Controls.Add(Me.radBtnMeters2Inches)
        Me.GroupBox1.Controls.Add(Me.radBtnInches2Meters)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(425, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 151)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert Measurement"
        '
        'radBtnInches2Meters
        '
        Me.radBtnInches2Meters.AutoSize = True
        Me.radBtnInches2Meters.ForeColor = System.Drawing.Color.White
        Me.radBtnInches2Meters.Location = New System.Drawing.Point(10, 57)
        Me.radBtnInches2Meters.Name = "radBtnInches2Meters"
        Me.radBtnInches2Meters.Size = New System.Drawing.Size(205, 29)
        Me.radBtnInches2Meters.TabIndex = 0
        Me.radBtnInches2Meters.TabStop = True
        Me.radBtnInches2Meters.Text = "Inches to Meters"
        Me.radBtnInches2Meters.UseVisualStyleBackColor = True
        '
        'radBtnMeters2Inches
        '
        Me.radBtnMeters2Inches.AutoSize = True
        Me.radBtnMeters2Inches.ForeColor = System.Drawing.Color.White
        Me.radBtnMeters2Inches.Location = New System.Drawing.Point(10, 98)
        Me.radBtnMeters2Inches.Name = "radBtnMeters2Inches"
        Me.radBtnMeters2Inches.Size = New System.Drawing.Size(205, 29)
        Me.radBtnMeters2Inches.TabIndex = 1
        Me.radBtnMeters2Inches.TabStop = True
        Me.radBtnMeters2Inches.Text = "Meters to Inches"
        Me.radBtnMeters2Inches.UseVisualStyleBackColor = True
        '
        'lblReturnResult
        '
        Me.lblReturnResult.AutoSize = True
        Me.lblReturnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnResult.ForeColor = System.Drawing.Color.White
        Me.lblReturnResult.Location = New System.Drawing.Point(420, 402)
        Me.lblReturnResult.Name = "lblReturnResult"
        Me.lblReturnResult.Size = New System.Drawing.Size(0, 29)
        Me.lblReturnResult.TabIndex = 5
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.Black
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(45, 476)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(227, 65)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(383, 476)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(227, 65)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(722, 476)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(227, 65)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(993, 563)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblReturnResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBoxEnterValue)
        Me.Controls.Add(Me.lblEnterValue)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picBoxMain)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Plans Conversion"
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxMain As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblEnterValue As Label
    Friend WithEvents txtBoxEnterValue As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBtnMeters2Inches As RadioButton
    Friend WithEvents radBtnInches2Meters As RadioButton
    Friend WithEvents lblReturnResult As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
