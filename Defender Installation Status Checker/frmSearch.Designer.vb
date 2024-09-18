<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Label1 = New Label()
        btnBack = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblType = New Label()
        lblNum = New Label()
        lblStatus = New Label()
        lblLoc = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblOff = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Arial Narrow", 16F)
        Label1.Location = New Point(409, 34)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 5, 10, 5)
        Label1.Size = New Size(276, 41)
        Label1.TabIndex = 3
        Label1.Text = "Search by Asset Number"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.BackgroundImage = My.Resources.Resources.back_icon1
        btnBack.BackgroundImageLayout = ImageLayout.Zoom
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 4
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Orange
        txtSearch.Font = New Font("Arial", 9F)
        txtSearch.Location = New Point(220, 127)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Insert asset number"
        txtSearch.Size = New Size(608, 25)
        txtSearch.TabIndex = 5
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Transparent
        btnSearch.BackgroundImage = My.Resources.Resources.search_icon1
        btnSearch.BackgroundImageLayout = ImageLayout.Zoom
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(834, 118)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(40, 40)
        btnSearch.TabIndex = 6
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Location = New Point(198, 211)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(696, 308)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 9F)
        Label2.Location = New Point(219, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 8
        Label2.Text = "Asset No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F)
        Label3.Location = New Point(219, 358)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 20)
        Label3.TabIndex = 9
        Label3.Text = "Defender Installation Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F)
        Label4.Location = New Point(219, 413)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 10
        Label4.Text = "Location"
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.BackColor = Color.Orange
        lblType.Font = New Font("Arial", 9F)
        lblType.ForeColor = Color.Black
        lblType.Location = New Point(451, 304)
        lblType.Name = "lblType"
        lblType.Size = New Size(12, 17)
        lblType.TabIndex = 13
        lblType.Text = " "
        ' 
        ' lblNum
        ' 
        lblNum.AutoSize = True
        lblNum.BackColor = Color.Orange
        lblNum.Font = New Font("Arial", 9F)
        lblNum.Location = New Point(451, 248)
        lblNum.Name = "lblNum"
        lblNum.Size = New Size(12, 17)
        lblNum.TabIndex = 14
        lblNum.Text = " "
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Orange
        lblStatus.Font = New Font("Arial", 9F)
        lblStatus.Location = New Point(451, 360)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(12, 17)
        lblStatus.TabIndex = 15
        lblStatus.Text = " "
        ' 
        ' lblLoc
        ' 
        lblLoc.AutoSize = True
        lblLoc.BackColor = Color.Orange
        lblLoc.Font = New Font("Arial", 9F)
        lblLoc.Location = New Point(451, 416)
        lblLoc.Name = "lblLoc"
        lblLoc.Size = New Size(12, 17)
        lblLoc.TabIndex = 16
        lblLoc.Text = " "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F)
        Label5.Location = New Point(219, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 17
        Label5.Text = "Asset Type"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F)
        Label6.Location = New Point(219, 468)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 18
        Label6.Text = "Office"
        ' 
        ' lblOff
        ' 
        lblOff.AutoSize = True
        lblOff.BackColor = Color.Orange
        lblOff.Font = New Font("Arial", 9F)
        lblOff.Location = New Point(451, 471)
        lblOff.Name = "lblOff"
        lblOff.Size = New Size(12, 17)
        lblOff.TabIndex = 19
        lblOff.Text = " "
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 601)
        Controls.Add(lblOff)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblLoc)
        Controls.Add(lblStatus)
        Controls.Add(lblNum)
        Controls.Add(lblType)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        MaximizeBox = False
        Name = "frmSearch"
        Text = "frmSearch"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblNum As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOff As Label
End Class
