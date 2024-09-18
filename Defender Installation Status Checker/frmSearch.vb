Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSearch
    Dim connString As String = "Data Source=C:\Users\user\Downloads\AMIRAH\disc.db;Version=3;"
    Dim connection As New SQLiteConnection(connString)
    Private previousForm As Form
    ' Constructor to accept the previous form as a parameter
    Public Sub New(previous As Form)
        InitializeComponent()
        previousForm = previous
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        previousForm.Show()
        ' Close the current form
        Me.Hide()
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNum.Text = ""
        lblStatus.Text = ""
        lblLoc.Text = ""
        lblOff.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim assetNum As String = txtSearch.Text.Trim() ' Get the search input

        Try
            connection.Open()
            Dim sql As String = "Select a.assetNum, a.assetStatus, a.assetType, l.locationName, o.officeRegion 
                                              FROM asset a 
                                              INNER Join office o ON a.officeID = o.officeID
                                              INNER Join location l ON o.locationID = l.locationID
                                              WHERE a.assetNum = @assetNum;"

            Dim command As New SQLiteCommand(sql, connection)
            command.Parameters.AddWithValue("@assetNum", assetNum)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Display the asset details
                lblNum.Text = reader("assetNum").ToString()
                lblType.Text = reader("assetType").ToString()
                If reader("assetStatus") = 1 Then
                    lblStatus.Text = "Installed"
                ElseIf reader("assetStatus") = 0 Then
                    lblStatus.Text = "Not Installed"
                End If
                lblLoc.Text = reader("locationName").ToString()
                lblOff.Text = reader("officeRegion").ToString()
            Else
                ' Handle case where asset is not found
                lblNum.Text = "Not found"
                lblStatus.Text = ""
                lblLoc.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class