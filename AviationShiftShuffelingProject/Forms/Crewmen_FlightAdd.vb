'Imports System.Data.DataTable
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports FontAwesome.Sharp


Public Class Crewmen_FlightAdd
    Dim connsql As New SqlConnection("Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security = True")

    Private Sub Crewmen_FlightAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load grid
        loadToGrid()

        ' add data to combo box
        cbGroup.Items.Add("A")
        cbGroup.Items.Add("B")
        cbGroup.Items.Add("C")
        cbGroup.Items.Add("D")

        cbPosition.Items.Add("CREWMEN")
        cbPosition.Items.Add("RIC")

    End Sub



    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'pass crewmen Details  to the database
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try


            ' check whether all the fields are empty
            If String.IsNullOrEmpty(tbName.Text) Then
                MsgBox(Name & "FILL The Field")
                tbName.Focus()

            ElseIf String.IsNullOrEmpty(cbGroup.Text) Then
                MsgBox("Fill The Field")
                cbGroup.Focus()

            ElseIf String.IsNullOrEmpty(cbPosition.Text) Then
                cbPosition.Focus()


            Else

                ' open database connection 
                connsql.Open()
                Dim namen As String
                namen = tbName.Text


                Dim queryString As String = "SELECT COUNT(*) FROM CREWMEMBERS_MASTER_TABLE WHERE Name = @userInput"
                Dim commandc As New SqlCommand(queryString, connsql)
                commandc.Parameters.AddWithValue("@userInput", namen)
                Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
                connsql.Close()


                If count > 0 Then

                    MsgBox("user name already exists in database")
                Else
                    connsql.Open()
                    ' insert data to the database

                    Dim name, group, position As String
                    name = tbName.Text
                    group = cbGroup.Text
                    position = cbPosition.Text

                    Dim sql As String = "INSERT INTO CREWMEMBERS_MASTER_TABLE (Name, [Group], Position) VALUES (@Name, @Group, @Position)"
                    Dim command As New SqlCommand(sql, connsql)
                    command.Parameters.AddWithValue("@Name", name)
                    command.Parameters.AddWithValue("@Group", group)
                    command.Parameters.AddWithValue("@Position", position)


                    command.ExecuteNonQuery()

                    'connection close
                    connsql.Close()
                    MsgBox(name & " Successfully Added To The Table")

                    'load data to the grid
                    loadToGrid()

                    ' user input does not exist in database
                End If




                ' DataGridView1.Rows.Add(tbName.Text, cbGroup.Text, cbPosition.Text)



            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()

        End Try

    End Sub


    'update crewmen details

    Private Sub Icoonbtnupdate_Click(sender As Object, e As EventArgs) Handles Icoonbtnupdate.Click
        Try


            ' check whether id is null or empty
            If String.IsNullOrEmpty(lblSelectedID.ToString) Then


                ' check whether all the fields are empty
            ElseIf String.IsNullOrEmpty(tbName.Text) Then
                MsgBox(Name & "FILL The Field")
                tbName.Focus()

            ElseIf String.IsNullOrEmpty(cbGroup.Text) Then
                MsgBox("Fill The Field")
                cbGroup.Focus()

            ElseIf String.IsNullOrEmpty(cbPosition.Text) Then
                cbPosition.Focus()



            Else

                ' open database connection 
                connsql.Open()
                Dim namen As String
                namen = tbName.Text


                Dim queryString As String = "SELECT COUNT(*) FROM CREWMEMBERS_MASTER_TABLE WHERE Name = @userInput"
                Dim commandc As New SqlCommand(queryString, connsql)
                commandc.Parameters.AddWithValue("@userInput", namen)
                Dim count As Integer = Convert.ToInt32(commandc.ExecuteScalar())
                connsql.Close()

                If count > 0 Then

                    MsgBox("user name already exists in database")
                Else

                    connsql.Open()
                    Dim cmd As New SqlCommand("UPDATE CREWMEMBERS_MASTER_TABLE SET Name = @Name,[Group] = @Group ,  position = @Position  WHERE ID = @lblSelectedID", connsql)
                    cmd.Parameters.AddWithValue("@Name", tbName.Text)
                    cmd.Parameters.AddWithValue("@Group", cbGroup.Text)
                    cmd.Parameters.AddWithValue("@Position", cbPosition.Text)
                    cmd.Parameters.AddWithValue("@lblSelectedID", lblSelectedID.Text)






                    Dim result As DialogResult = MessageBox.Show("Do you want to change Crewmen Name ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        ' User clicked Yes
                        MsgBox(tbName.Text & " Successfully Updated ")
                        cmd.ExecuteNonQuery()


                    End If
                    connsql.Close()






                    loadToGrid()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connsql.Close()

        End Try

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        ' Get the selected row data
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

        ' Get the values of the cells in the selected row
        Dim Sid As Object = selectedRow.Cells(0).Value
        Dim Sname As Object = selectedRow.Cells(1).Value
        Dim Sgroup As Object = selectedRow.Cells(2).Value
        Dim Sposition As Object = selectedRow.Cells(3).Value

        tbName.Text = Sname
        cbGroup.Text = Sgroup
        cbPosition.Text = Sposition
        lblSelectedID.Text = Sid

    End Sub





    'load data to gridview
    Public Sub loadToGrid()

        Try
            connsql.Open()

            Dim cmdsql As New SqlCommand("select * from CREWMEMBERS_MASTER_TABLE ", connsql)
            Dim dasql As New SqlDataAdapter
            dasql.SelectCommand = cmdsql
            Dim dtsql As New DataTable

            dasql.Fill(dtsql)
            DataGridView1.Columns("AID").DataPropertyName = "ID"
            DataGridView1.Columns("AName").DataPropertyName = "Name"
            DataGridView1.Columns("AGroup").DataPropertyName = "Group"
            DataGridView1.Columns("APosition").DataPropertyName = "Position"

            DataGridView1.DataSource = dtsql.DefaultView
            DataGridView1.AllowUserToAddRows = False

            connsql.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    ' delete the record 
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            If String.IsNullOrEmpty(lblSelectedID.ToString) Then

            Else
                connsql.Open()
                Dim cmd As New SqlCommand("DELETE FROM CREWMEMBERS_MASTER_TABLE WHERE ID = @ID", connsql)
                cmd.Parameters.AddWithValue("@ID", lblSelectedID.Text)





                Dim result As DialogResult = MessageBox.Show("Do you want to delete Name ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User clicked Yes
                    MsgBox(tbName.Text & " Successfully deleted ")
                    cmd.ExecuteNonQuery()


                End If
                connsql.Close()
                loadToGrid()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

    End Sub
End Class