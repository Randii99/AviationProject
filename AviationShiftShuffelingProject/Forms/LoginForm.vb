Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm
    Dim connsql As New SqlConnection("Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security = True")


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' hide password when typing
        tbPS.UseSystemPasswordChar = True

    End Sub

    Private Sub cbSP_CheckedChanged(sender As Object, e As EventArgs) Handles cbSP.CheckedChanged
        If cbSP.Checked Then
            tbPS.UseSystemPasswordChar = False
        Else
            tbPS.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            ' check whether all the fields are empty
            If String.IsNullOrEmpty(tbUName.Text) Then
                MsgBox("Fill The Name Field")
                tbUName.Focus()

            ElseIf String.IsNullOrEmpty(tbPS.Text) Then
                MsgBox("Fill The Password Field")
                tbPS.Focus()

            Else
                'when all the fields are filled
                'Open database connection 
                connsql.Open()
                Dim namen As String
                Dim pass As String
                namen = tbUName.Text
                pass = tbPS.Text

                'check whether the USER name and PASSWORD are correct
                Dim queryString As String = "SELECT COUNT(*) FROM LOGIN_TABLE WHERE USERNAME = @user AND PASSWORD = @password"
                Dim commandc As New SqlCommand(queryString, connsql)
                commandc.Parameters.AddWithValue("@user", namen)
                commandc.Parameters.AddWithValue("@password", pass)
                Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())

                If count > 0 Then
                    'login successful
                    MsgBox("Successfully Login")
                Else
                    'login failed
                    Dim queryString2 As String = "SELECT COUNT(*) FROM LOGIN_TABLE WHERE USERNAME = @user"
                    Dim commandc2 As New SqlCommand(queryString2, connsql)
                    commandc2.Parameters.AddWithValue("@user", namen)
                    Dim count2 As Integer = Convert.ToInt32(commandc2.ExecuteScalar())

                    If count2 > 0 Then
                        'username is correct but password is wrong
                        MsgBox("Incorrect password. Please try again.")
                        tbPS.Focus()
                        tbPS.SelectAll()
                    Else
                        'username is incorrect
                        MsgBox("Username or password is wrong. Please try again.")
                        tbUName.Focus()
                    End If
                End If

                connsql.Close()
            End If

        Catch ex As Exception

        End Try

    End Sub

End Class