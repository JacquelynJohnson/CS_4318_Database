﻿'Jacquelyn Johnson wrote this code...
Imports MySql.Data.MySqlClient

Public Class newUser
  'create connection varibles for database
  Dim mysqlConn As MySqlConnection
  Dim sql As MySqlCommand

  'this method loads the combobox with the data pulled from the database for selection later
  Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    popCbb()

  End Sub

  'this sub will collect data from the class table in the database, stuff it in a dataset, and load it in a 
  'combobox for selection in the form 
  Private Sub popCbb()
    Dim query As String       'var to use for sql command to be passed to the database
    Dim dr As MySqlDataReader 'needed to read the data from the database into a local variable

    Try
      mysqlConn = New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
      query = "select classID, className from class"  'selects only the classID and the className from the db

      mysqlConn.Open()        'open db connection
      sql = New MySqlCommand(query, mysqlConn)  'pass mysql statement and open db connection
      dr = sql.ExecuteReader
      While dr.Read = True  'will loop until no more tuples are found in the db
        Dim clId As String
        Dim name As String
        Dim both As String  'variable to hold string concat
        clId = CType(dr("classID"), String)
        name = CType(dr("className"), String)
        both = clId + " " + name
        cbbClassPicker.Items.Add(both)  'adds as concatenated string to the combobox for user selection
      End While

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    Finally
      mysqlConn.Close()
    End Try

  End Sub

  'sub to handle submit button click
  Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    'create local variables to collect information from the form
    Dim fName As String
    Dim lName As String
    Dim gLevel As String
    Dim studPassword As String
    Dim email As String

    'collect information from the fields and send to the Student Table in the connected biolog database
    fName = txtStudFName.Text
    lName = txtStudLName.Text
    gLevel = CType(cbbGradeLevel.SelectedItem, String)
    studPassword = txtStudNewPass.Text
    email = txtStudEmail.Text
    'MessageBox.Show(fName + " line 60") 'here to make sure that text field capture is working properly

    mysqlConn = New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")

    'try block to insert values in Student table of biolog database
    Try

      Dim query As String
      'define the sql statement that will be executed
      query = "INSERT INTO `student`(`studentID`, `classID`, `firstName`, `lastName`, `gradeLevel`, `email`, `studentPassword`) VALUES (@studentID, @classID, @fName, @lName, @gLevel, @email, @studPassword)"
      Dim sql As New MySqlCommand(query, mysqlConn)
      'reader = sql.ExecuteReader
      sql.Parameters.Add("@studentID", MySqlDbType.Int16).Value = txtStudID.Text
      sql.Parameters.Add("@classID", MySqlDbType.String).Value = getClassID()
      sql.Parameters.Add("@fName", MySqlDbType.VarChar).Value = txtStudFName.Text
      sql.Parameters.Add("@lName", MySqlDbType.VarChar).Value = txtStudLName.Text
      sql.Parameters.Add("@glevel", MySqlDbType.VarChar).Value = cbbGradeLevel.SelectedItem
      sql.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtStudEmail.Text
      sql.Parameters.Add("@studPassword", MySqlDbType.VarChar).Value = txtStudNewPass.Text


      'open sql db connection
      mysqlConn.Open()

      If sql.ExecuteNonQuery() = 1 Then
        'show successful addition to table for user benefit
        MessageBox.Show("Data Saved in Student Table")
        mysqlConn.Close()
      End If

    Catch ex As Exception
      'show exception that is thrown
      MessageBox.Show(ex.Message)
    Finally
      'close connection even if exception is thrown
      mysqlConn.Close()

    End Try
    Me.Close()
    LoginForm.Show()

  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    'discards form instance and returns to login form
    Me.Close()
    LoginForm.Show()
  End Sub

  'this function will return the classID number to pass to the database in order to assign the student to the correct class
  Private Function getClassID() As String
    Dim id As String
    Dim actual As String
    id = CType(cbbClassPicker.SelectedItem(), String)
    actual = id.Substring(0, 4)

    Return actual
  End Function
End Class