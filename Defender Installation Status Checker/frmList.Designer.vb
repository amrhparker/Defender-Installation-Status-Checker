<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        btnBack = New Button()
        lblState = New Label()
        ListView1 = New ListView()
        SuspendLayout()
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
        btnBack.TabIndex = 1
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.BackColor = Color.Orange
        lblState.Cursor = Cursors.Hand
        lblState.Font = New Font("Arial Narrow", 16F)
        lblState.Location = New Point(537, 34)
        lblState.Name = "lblState"
        lblState.Padding = New Padding(10, 5, 10, 5)
        lblState.Size = New Size(20, 41)
        lblState.TabIndex = 2
        lblState.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Orange
        ListView1.Font = New Font("Arial Narrow", 9F)
        ListView1.Location = New Point(96, 107)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(902, 384)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' frmList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1094, 601)
        Controls.Add(ListView1)
        Controls.Add(lblState)
        Controls.Add(btnBack)
        MaximizeBox = False
        Name = "frmList"
        Text = "frmPerlis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblState As Label
    Friend WithEvents ListView1 As ListView
End Class
