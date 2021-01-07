<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.filenameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputListBox = New System.Windows.Forms.ListBox()
        Me.goButton = New System.Windows.Forms.Button()
        Me.outputListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkTextBox = New System.Windows.Forms.TextBox()
        Me.checkinputListBox = New System.Windows.Forms.ListBox()
        Me.inputcolumnGroupBox = New System.Windows.Forms.GroupBox()
        Me.iFiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.iFourRadioButton = New System.Windows.Forms.RadioButton()
        Me.iThreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.iTwoRadioButton = New System.Windows.Forms.RadioButton()
        Me.iOneRadioButton = New System.Windows.Forms.RadioButton()
        Me.checkcolumnGroupBox = New System.Windows.Forms.GroupBox()
        Me.cFiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.cFourRadioButton = New System.Windows.Forms.RadioButton()
        Me.cThreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.cTwoRadioButton = New System.Windows.Forms.RadioButton()
        Me.cOneRadioButton = New System.Windows.Forms.RadioButton()
        Me.inputnumGroupBox = New System.Windows.Forms.GroupBox()
        Me.AIfiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.AIfourRadioButton = New System.Windows.Forms.RadioButton()
        Me.AIthreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.AItwoRadioButton = New System.Windows.Forms.RadioButton()
        Me.AIoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.checknumGroupBox = New System.Windows.Forms.GroupBox()
        Me.CIfiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.CIfourRadioButton = New System.Windows.Forms.RadioButton()
        Me.CIoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.CIthreeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CItwoRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dupRadioButton = New System.Windows.Forms.RadioButton()
        Me.commonRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputcolumnGroupBox.SuspendLayout()
        Me.checkcolumnGroupBox.SuspendLayout()
        Me.inputnumGroupBox.SuspendLayout()
        Me.checknumGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'filenameTextBox
        '
        Me.filenameTextBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filenameTextBox.Location = New System.Drawing.Point(12, 32)
        Me.filenameTextBox.Name = "filenameTextBox"
        Me.filenameTextBox.Size = New System.Drawing.Size(277, 30)
        Me.filenameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Name:"
        '
        'inputListBox
        '
        Me.inputListBox.FormattingEnabled = True
        Me.inputListBox.Location = New System.Drawing.Point(112, 153)
        Me.inputListBox.Name = "inputListBox"
        Me.inputListBox.Size = New System.Drawing.Size(360, 641)
        Me.inputListBox.TabIndex = 10
        '
        'goButton
        '
        Me.goButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goButton.Location = New System.Drawing.Point(959, 5)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(99, 57)
        Me.goButton.TabIndex = 4
        Me.goButton.Text = "Check"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'outputListBox
        '
        Me.outputListBox.FormattingEnabled = True
        Me.outputListBox.Location = New System.Drawing.Point(959, 153)
        Me.outputListBox.Name = "outputListBox"
        Me.outputListBox.Size = New System.Drawing.Size(360, 641)
        Me.outputListBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Check Against:"
        '
        'checkTextBox
        '
        Me.checkTextBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkTextBox.Location = New System.Drawing.Point(478, 32)
        Me.checkTextBox.Name = "checkTextBox"
        Me.checkTextBox.Size = New System.Drawing.Size(277, 30)
        Me.checkTextBox.TabIndex = 3
        '
        'checkinputListBox
        '
        Me.checkinputListBox.FormattingEnabled = True
        Me.checkinputListBox.Location = New System.Drawing.Point(578, 152)
        Me.checkinputListBox.Name = "checkinputListBox"
        Me.checkinputListBox.Size = New System.Drawing.Size(360, 641)
        Me.checkinputListBox.TabIndex = 11
        '
        'inputcolumnGroupBox
        '
        Me.inputcolumnGroupBox.Controls.Add(Me.iFiveRadioButton)
        Me.inputcolumnGroupBox.Controls.Add(Me.iFourRadioButton)
        Me.inputcolumnGroupBox.Controls.Add(Me.iThreeRadioButton)
        Me.inputcolumnGroupBox.Controls.Add(Me.iTwoRadioButton)
        Me.inputcolumnGroupBox.Controls.Add(Me.iOneRadioButton)
        Me.inputcolumnGroupBox.Location = New System.Drawing.Point(12, 153)
        Me.inputcolumnGroupBox.Name = "inputcolumnGroupBox"
        Me.inputcolumnGroupBox.Size = New System.Drawing.Size(94, 186)
        Me.inputcolumnGroupBox.TabIndex = 8
        Me.inputcolumnGroupBox.TabStop = False
        Me.inputcolumnGroupBox.Text = "Which column would you like to cross check?"
        '
        'iFiveRadioButton
        '
        Me.iFiveRadioButton.AutoSize = True
        Me.iFiveRadioButton.Location = New System.Drawing.Point(0, 154)
        Me.iFiveRadioButton.Name = "iFiveRadioButton"
        Me.iFiveRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.iFiveRadioButton.TabIndex = 4
        Me.iFiveRadioButton.TabStop = True
        Me.iFiveRadioButton.Text = "Column 5"
        Me.iFiveRadioButton.UseVisualStyleBackColor = True
        '
        'iFourRadioButton
        '
        Me.iFourRadioButton.AutoSize = True
        Me.iFourRadioButton.Location = New System.Drawing.Point(0, 131)
        Me.iFourRadioButton.Name = "iFourRadioButton"
        Me.iFourRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.iFourRadioButton.TabIndex = 3
        Me.iFourRadioButton.TabStop = True
        Me.iFourRadioButton.Text = "Column 4"
        Me.iFourRadioButton.UseVisualStyleBackColor = True
        '
        'iThreeRadioButton
        '
        Me.iThreeRadioButton.AutoSize = True
        Me.iThreeRadioButton.Location = New System.Drawing.Point(0, 108)
        Me.iThreeRadioButton.Name = "iThreeRadioButton"
        Me.iThreeRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.iThreeRadioButton.TabIndex = 2
        Me.iThreeRadioButton.TabStop = True
        Me.iThreeRadioButton.Text = "Column 3"
        Me.iThreeRadioButton.UseVisualStyleBackColor = True
        '
        'iTwoRadioButton
        '
        Me.iTwoRadioButton.AutoSize = True
        Me.iTwoRadioButton.Location = New System.Drawing.Point(0, 85)
        Me.iTwoRadioButton.Name = "iTwoRadioButton"
        Me.iTwoRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.iTwoRadioButton.TabIndex = 1
        Me.iTwoRadioButton.TabStop = True
        Me.iTwoRadioButton.Text = "Column 2"
        Me.iTwoRadioButton.UseVisualStyleBackColor = True
        '
        'iOneRadioButton
        '
        Me.iOneRadioButton.AutoSize = True
        Me.iOneRadioButton.Location = New System.Drawing.Point(0, 61)
        Me.iOneRadioButton.Name = "iOneRadioButton"
        Me.iOneRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.iOneRadioButton.TabIndex = 0
        Me.iOneRadioButton.TabStop = True
        Me.iOneRadioButton.Text = "Column 1"
        Me.iOneRadioButton.UseVisualStyleBackColor = True
        '
        'checkcolumnGroupBox
        '
        Me.checkcolumnGroupBox.Controls.Add(Me.cFiveRadioButton)
        Me.checkcolumnGroupBox.Controls.Add(Me.cFourRadioButton)
        Me.checkcolumnGroupBox.Controls.Add(Me.cThreeRadioButton)
        Me.checkcolumnGroupBox.Controls.Add(Me.cTwoRadioButton)
        Me.checkcolumnGroupBox.Controls.Add(Me.cOneRadioButton)
        Me.checkcolumnGroupBox.Location = New System.Drawing.Point(478, 153)
        Me.checkcolumnGroupBox.Name = "checkcolumnGroupBox"
        Me.checkcolumnGroupBox.Size = New System.Drawing.Size(94, 186)
        Me.checkcolumnGroupBox.TabIndex = 9
        Me.checkcolumnGroupBox.TabStop = False
        Me.checkcolumnGroupBox.Text = "Which column would you like to check agianst?"
        '
        'cFiveRadioButton
        '
        Me.cFiveRadioButton.AutoSize = True
        Me.cFiveRadioButton.Location = New System.Drawing.Point(0, 154)
        Me.cFiveRadioButton.Name = "cFiveRadioButton"
        Me.cFiveRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.cFiveRadioButton.TabIndex = 4
        Me.cFiveRadioButton.TabStop = True
        Me.cFiveRadioButton.Text = "Column 5"
        Me.cFiveRadioButton.UseVisualStyleBackColor = True
        '
        'cFourRadioButton
        '
        Me.cFourRadioButton.AutoSize = True
        Me.cFourRadioButton.Location = New System.Drawing.Point(0, 131)
        Me.cFourRadioButton.Name = "cFourRadioButton"
        Me.cFourRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.cFourRadioButton.TabIndex = 3
        Me.cFourRadioButton.TabStop = True
        Me.cFourRadioButton.Text = "Column 4"
        Me.cFourRadioButton.UseVisualStyleBackColor = True
        '
        'cThreeRadioButton
        '
        Me.cThreeRadioButton.AutoSize = True
        Me.cThreeRadioButton.Location = New System.Drawing.Point(0, 108)
        Me.cThreeRadioButton.Name = "cThreeRadioButton"
        Me.cThreeRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.cThreeRadioButton.TabIndex = 2
        Me.cThreeRadioButton.TabStop = True
        Me.cThreeRadioButton.Text = "Column 3"
        Me.cThreeRadioButton.UseVisualStyleBackColor = True
        '
        'cTwoRadioButton
        '
        Me.cTwoRadioButton.AutoSize = True
        Me.cTwoRadioButton.Location = New System.Drawing.Point(0, 85)
        Me.cTwoRadioButton.Name = "cTwoRadioButton"
        Me.cTwoRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.cTwoRadioButton.TabIndex = 1
        Me.cTwoRadioButton.TabStop = True
        Me.cTwoRadioButton.Text = "Column 2"
        Me.cTwoRadioButton.UseVisualStyleBackColor = True
        '
        'cOneRadioButton
        '
        Me.cOneRadioButton.AutoSize = True
        Me.cOneRadioButton.Location = New System.Drawing.Point(0, 61)
        Me.cOneRadioButton.Name = "cOneRadioButton"
        Me.cOneRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.cOneRadioButton.TabIndex = 0
        Me.cOneRadioButton.TabStop = True
        Me.cOneRadioButton.Text = "Column 1"
        Me.cOneRadioButton.UseVisualStyleBackColor = True
        '
        'inputnumGroupBox
        '
        Me.inputnumGroupBox.Controls.Add(Me.AIfiveRadioButton)
        Me.inputnumGroupBox.Controls.Add(Me.AIfourRadioButton)
        Me.inputnumGroupBox.Controls.Add(Me.AIthreeRadioButton)
        Me.inputnumGroupBox.Controls.Add(Me.AItwoRadioButton)
        Me.inputnumGroupBox.Controls.Add(Me.AIoneRadioButton)
        Me.inputnumGroupBox.Location = New System.Drawing.Point(12, 69)
        Me.inputnumGroupBox.Name = "inputnumGroupBox"
        Me.inputnumGroupBox.Size = New System.Drawing.Size(277, 78)
        Me.inputnumGroupBox.TabIndex = 6
        Me.inputnumGroupBox.TabStop = False
        Me.inputnumGroupBox.Text = "Amount of columns:"
        '
        'AIfiveRadioButton
        '
        Me.AIfiveRadioButton.AutoSize = True
        Me.AIfiveRadioButton.Location = New System.Drawing.Point(238, 19)
        Me.AIfiveRadioButton.Name = "AIfiveRadioButton"
        Me.AIfiveRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.AIfiveRadioButton.TabIndex = 5
        Me.AIfiveRadioButton.TabStop = True
        Me.AIfiveRadioButton.Text = "5"
        Me.AIfiveRadioButton.UseVisualStyleBackColor = True
        '
        'AIfourRadioButton
        '
        Me.AIfourRadioButton.AutoSize = True
        Me.AIfourRadioButton.Location = New System.Drawing.Point(180, 19)
        Me.AIfourRadioButton.Name = "AIfourRadioButton"
        Me.AIfourRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.AIfourRadioButton.TabIndex = 4
        Me.AIfourRadioButton.TabStop = True
        Me.AIfourRadioButton.Text = "4"
        Me.AIfourRadioButton.UseVisualStyleBackColor = True
        '
        'AIthreeRadioButton
        '
        Me.AIthreeRadioButton.AutoSize = True
        Me.AIthreeRadioButton.Location = New System.Drawing.Point(122, 19)
        Me.AIthreeRadioButton.Name = "AIthreeRadioButton"
        Me.AIthreeRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.AIthreeRadioButton.TabIndex = 3
        Me.AIthreeRadioButton.TabStop = True
        Me.AIthreeRadioButton.Text = "3"
        Me.AIthreeRadioButton.UseVisualStyleBackColor = True
        '
        'AItwoRadioButton
        '
        Me.AItwoRadioButton.AutoSize = True
        Me.AItwoRadioButton.Location = New System.Drawing.Point(64, 19)
        Me.AItwoRadioButton.Name = "AItwoRadioButton"
        Me.AItwoRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.AItwoRadioButton.TabIndex = 2
        Me.AItwoRadioButton.TabStop = True
        Me.AItwoRadioButton.Text = "2"
        Me.AItwoRadioButton.UseVisualStyleBackColor = True
        '
        'AIoneRadioButton
        '
        Me.AIoneRadioButton.AutoSize = True
        Me.AIoneRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.AIoneRadioButton.Name = "AIoneRadioButton"
        Me.AIoneRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.AIoneRadioButton.TabIndex = 1
        Me.AIoneRadioButton.TabStop = True
        Me.AIoneRadioButton.Text = "1"
        Me.AIoneRadioButton.UseVisualStyleBackColor = True
        '
        'checknumGroupBox
        '
        Me.checknumGroupBox.Controls.Add(Me.CIfiveRadioButton)
        Me.checknumGroupBox.Controls.Add(Me.CIfourRadioButton)
        Me.checknumGroupBox.Controls.Add(Me.CIoneRadioButton)
        Me.checknumGroupBox.Controls.Add(Me.CIthreeRadioButton)
        Me.checknumGroupBox.Controls.Add(Me.CItwoRadioButton)
        Me.checknumGroupBox.Location = New System.Drawing.Point(478, 68)
        Me.checknumGroupBox.Name = "checknumGroupBox"
        Me.checknumGroupBox.Size = New System.Drawing.Size(277, 78)
        Me.checknumGroupBox.TabIndex = 7
        Me.checknumGroupBox.TabStop = False
        Me.checknumGroupBox.Text = "Amount of columns:"
        '
        'CIfiveRadioButton
        '
        Me.CIfiveRadioButton.AutoSize = True
        Me.CIfiveRadioButton.Location = New System.Drawing.Point(239, 20)
        Me.CIfiveRadioButton.Name = "CIfiveRadioButton"
        Me.CIfiveRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.CIfiveRadioButton.TabIndex = 10
        Me.CIfiveRadioButton.TabStop = True
        Me.CIfiveRadioButton.Text = "5"
        Me.CIfiveRadioButton.UseVisualStyleBackColor = True
        '
        'CIfourRadioButton
        '
        Me.CIfourRadioButton.AutoSize = True
        Me.CIfourRadioButton.Location = New System.Drawing.Point(181, 20)
        Me.CIfourRadioButton.Name = "CIfourRadioButton"
        Me.CIfourRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.CIfourRadioButton.TabIndex = 9
        Me.CIfourRadioButton.TabStop = True
        Me.CIfourRadioButton.Text = "4"
        Me.CIfourRadioButton.UseVisualStyleBackColor = True
        '
        'CIoneRadioButton
        '
        Me.CIoneRadioButton.AutoSize = True
        Me.CIoneRadioButton.Location = New System.Drawing.Point(7, 20)
        Me.CIoneRadioButton.Name = "CIoneRadioButton"
        Me.CIoneRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.CIoneRadioButton.TabIndex = 6
        Me.CIoneRadioButton.TabStop = True
        Me.CIoneRadioButton.Text = "1"
        Me.CIoneRadioButton.UseVisualStyleBackColor = True
        '
        'CIthreeRadioButton
        '
        Me.CIthreeRadioButton.AutoSize = True
        Me.CIthreeRadioButton.Location = New System.Drawing.Point(123, 20)
        Me.CIthreeRadioButton.Name = "CIthreeRadioButton"
        Me.CIthreeRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.CIthreeRadioButton.TabIndex = 8
        Me.CIthreeRadioButton.TabStop = True
        Me.CIthreeRadioButton.Text = "3"
        Me.CIthreeRadioButton.UseVisualStyleBackColor = True
        '
        'CItwoRadioButton
        '
        Me.CItwoRadioButton.AutoSize = True
        Me.CItwoRadioButton.Location = New System.Drawing.Point(65, 20)
        Me.CItwoRadioButton.Name = "CItwoRadioButton"
        Me.CItwoRadioButton.Size = New System.Drawing.Size(31, 17)
        Me.CItwoRadioButton.TabIndex = 7
        Me.CItwoRadioButton.TabStop = True
        Me.CItwoRadioButton.Text = "2"
        Me.CItwoRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dupRadioButton)
        Me.GroupBox1.Controls.Add(Me.commonRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(959, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 78)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort Mode"
        '
        'dupRadioButton
        '
        Me.dupRadioButton.AutoSize = True
        Me.dupRadioButton.Location = New System.Drawing.Point(7, 43)
        Me.dupRadioButton.Name = "dupRadioButton"
        Me.dupRadioButton.Size = New System.Drawing.Size(120, 17)
        Me.dupRadioButton.TabIndex = 1
        Me.dupRadioButton.TabStop = True
        Me.dupRadioButton.Text = "Eliminate Duplicates"
        Me.dupRadioButton.UseVisualStyleBackColor = True
        '
        'commonRadioButton
        '
        Me.commonRadioButton.AutoSize = True
        Me.commonRadioButton.Location = New System.Drawing.Point(7, 19)
        Me.commonRadioButton.Name = "commonRadioButton"
        Me.commonRadioButton.Size = New System.Drawing.Size(115, 17)
        Me.commonRadioButton.TabIndex = 0
        Me.commonRadioButton.TabStop = True
        Me.commonRadioButton.Text = "Find Common Data"
        Me.commonRadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1213, 797)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "© Philip Tasabia"
        '
        'MainForm
        '
        Me.AcceptButton = Me.goButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 741)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.checknumGroupBox)
        Me.Controls.Add(Me.inputnumGroupBox)
        Me.Controls.Add(Me.checkcolumnGroupBox)
        Me.Controls.Add(Me.inputcolumnGroupBox)
        Me.Controls.Add(Me.checkinputListBox)
        Me.Controls.Add(Me.checkTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outputListBox)
        Me.Controls.Add(Me.goButton)
        Me.Controls.Add(Me.inputListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filenameTextBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cross Check"
        Me.inputcolumnGroupBox.ResumeLayout(False)
        Me.inputcolumnGroupBox.PerformLayout()
        Me.checkcolumnGroupBox.ResumeLayout(False)
        Me.checkcolumnGroupBox.PerformLayout()
        Me.inputnumGroupBox.ResumeLayout(False)
        Me.inputnumGroupBox.PerformLayout()
        Me.checknumGroupBox.ResumeLayout(False)
        Me.checknumGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents filenameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents inputListBox As ListBox
    Friend WithEvents goButton As Button
    Friend WithEvents outputListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents checkTextBox As TextBox
    Friend WithEvents checkinputListBox As ListBox
    Friend WithEvents inputcolumnGroupBox As GroupBox
    Friend WithEvents iFiveRadioButton As RadioButton
    Friend WithEvents iFourRadioButton As RadioButton
    Friend WithEvents iThreeRadioButton As RadioButton
    Friend WithEvents iTwoRadioButton As RadioButton
    Friend WithEvents iOneRadioButton As RadioButton
    Friend WithEvents checkcolumnGroupBox As GroupBox
    Friend WithEvents cFiveRadioButton As RadioButton
    Friend WithEvents cFourRadioButton As RadioButton
    Friend WithEvents cThreeRadioButton As RadioButton
    Friend WithEvents cTwoRadioButton As RadioButton
    Friend WithEvents cOneRadioButton As RadioButton
    Friend WithEvents inputnumGroupBox As GroupBox
    Friend WithEvents AIfiveRadioButton As RadioButton
    Friend WithEvents AIfourRadioButton As RadioButton
    Friend WithEvents AIthreeRadioButton As RadioButton
    Friend WithEvents AItwoRadioButton As RadioButton
    Friend WithEvents AIoneRadioButton As RadioButton
    Friend WithEvents checknumGroupBox As GroupBox
    Friend WithEvents CIfiveRadioButton As RadioButton
    Friend WithEvents CIfourRadioButton As RadioButton
    Friend WithEvents CIoneRadioButton As RadioButton
    Friend WithEvents CIthreeRadioButton As RadioButton
    Friend WithEvents CItwoRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dupRadioButton As RadioButton
    Friend WithEvents commonRadioButton As RadioButton
    Friend WithEvents Label3 As Label
End Class
