Imports System.Data.SQLite

Public Class frmList
    Dim connString As String = "Data Source=C:\Users\user\Downloads\AMIRAH\disc.db;Version=3;"
    Dim connection As New SQLiteConnection(connString)
    Dim locID As Integer
    Private previousForm As Form
    ' Constructor to accept the previous form as a parameter
    Public Sub New(previous As Form, loc As Integer)
        InitializeComponent()
        previousForm = previous
        locID = loc
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Show the previous form
        previousForm.Show()
        ' Close the current form
        Me.Hide()
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns in the ListView
        'ListView1.Columns.Add("Asset ID", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset Number", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset Type", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Asset Status", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Office", 100, HorizontalAlignment.Center)
        If locID = 1 Then
            lblState.Text = "Perlis"
        ElseIf locID = 2 Then
            lblState.Text = "Kedah"
        ElseIf locID = 3 Then
            lblState.Text = "Pulau Pinang"
        ElseIf locID = 4 Then
            lblState.Text = "Perak"
        ElseIf locID = 5 Then
            lblState.Text = "Headquarters"
        ElseIf locID = 6 Then
            lblState.Text = "Negeri Sembilan"
        ElseIf locID = 7 Then
            lblState.Text = "Melaka"
        ElseIf locID = 8 Then
            lblState.Text = "Johor"
        ElseIf locID = 9 Then
            lblState.Text = "Pahang"
        ElseIf locID = 10 Then
            lblState.Text = "Kelantan"
        ElseIf locID = 11 Then
            lblState.Text = "Terengganu"
        ElseIf locID = 12 Then
            lblState.Text = "Sabah"
        ElseIf locID = 13 Then
            lblState.Text = "Sarawak"
        End If
        retrieveData()
    End Sub

    Private Sub retrieveData()
        Dim connString As String = "Data Source=C:\Users\user\Downloads\AMIRAH\disc.db;Version=3;"
        Dim connection As New SQLiteConnection(connString)

        Try
            connection.Open()
            'Dim sql As String = "SELECT a.assetID, a.assetNum, a.assetType, a.assetStatus, l.locationName " & "FROM asset a " & "INNER JOIN location l ON a.locationID = l.locationID " &  "WHERE a.locationID = @locID"
            Dim sql As String = "SELECT a.assetNum, a.assetType, a.assetStatus, o.officeRegion 
                                              FROM asset a JOIN office o ON a.officeID = o.officeID JOIN location l ON l.locationID = o.locationID
                                              WHERE  l.locationID = @locID;"

            Dim command As New SQLiteCommand(Sql, connection)
            command.Parameters.AddWithValue("@locID", locID)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            ' Clear existing items in the ListView
            ListView1.Items.Clear()

            ' Loop through the data and add it to the ListView
            While reader.Read()
                Dim item As New ListViewItem(reader("assetNum").ToString())
                item.SubItems.Add(reader("assetType").ToString())
                If reader("assetStatus") = 1 Then
                    item.SubItems.Add("Installed")
                ElseIf reader("assetStatus") = 0 Then
                    item.SubItems.Add("Not Installed")
                End If
                item.SubItems.Add(reader("officeRegion").ToString())

                ListView1.Items.Add(item) ' Add the row to the ListView
            End While
        Catch ex As Exception
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class