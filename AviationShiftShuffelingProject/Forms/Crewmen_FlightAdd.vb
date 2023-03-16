'Imports System.Data.DataTable
Imports System.CodeDom
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Shapes
Imports FontAwesome.Sharp

'crewmen 
Public Class Crewmen_FlightAdd
    Dim connsql As New SqlConnection("Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security = True")

    Private Sub Crewmen_FlightAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load grid
        loadToGrid()



        loadToGrid1()


        loadAirlineCode()

        ' add data to combo box
        cbGroup.Items.Add("A")
        cbGroup.Items.Add("B")
        cbGroup.Items.Add("C")
        cbGroup.Items.Add("D")

        cbPosition.Items.Add("CREWMEN")
        cbPosition.Items.Add("RIC")



        For i As Integer = 0 To 24
            Dim formattedNumber As String = i.ToString("D2")
            cbStd.Items.Add(formattedNumber.ToString())
        Next


        For j As Integer = 0 To 60
            Dim formattedNumber As String = j.ToString("D2")
            cbStd1.Items.Add(formattedNumber.ToString())
        Next



        cbDT.Items.Add("00:30") 'add to combo box
        cbDT.Items.Add("01:00")
        cbDT.Items.Add("01:30")
        cbDT.Items.Add("02:00")



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


    Public Sub loadToGrid1()

        Try
            connsql.Open()

            'Create a SQL command to select all the rows from the FLIGHT_MASTER_TABLE
            Dim cmd As New SqlCommand("SELECT * FROM FLIGHT_MASTER_TABLE", connsql)

            'Create a SQL data adapter and set its select command to the SQL command
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = cmd


            DataGridView2.Columns("fno").DataPropertyName = "Flight_No"
            DataGridView2.Columns("alc").DataPropertyName = "Airline_Code"
            DataGridView2.Columns("fid1").DataPropertyName = "FID"

            'Create a new DataTable object to hold the data
            Dim table As New DataTable()

            'Fill the DataTable with the data from the SQL data adapter
            adapter.Fill(table)



            'Add new columns to the DataTable
            table.Columns.Add("std1", GetType(TimeSpan))
            table.Columns.Add("dipart", GetType(TimeSpan))
            table.Columns.Add("eta", GetType(TimeSpan))
            table.Columns.Add("dt", GetType(DateTime))




            'Loop through each row in the DataTable
            For Each row As DataRow In table.Rows
                'Get the FID value from the current row
                Dim fid As Integer = row("FID")

                'Create a SQL command to select the STD, DIP TIME, Date, and ETA values from the FLIGHT_TIME_TABLE where the FID matches
                Dim query As String = "SELECT * FROM FLIGHT_TIME_TABLE WHERE FID = @FID"
                Dim cmd2 As New SqlCommand(query, connsql)

                'Add a parameter for the FID value
                cmd2.Parameters.AddWithValue("@FID", fid)

                'Execute the SQL command and get a SqlDataReader object
                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                'If the reader has rows, read the first row and get the values for the std, dTime, eta, and dt columns
                If reader.HasRows Then
                    reader.Read()

                    Dim std As TimeSpan = reader("STD")
                    Dim dTime As TimeSpan = reader("DIP TIME")
                    Dim eta As TimeSpan = reader("ETA")
                    Dim dt As DateTime = reader("Date")

                    'Assign the values to the std1, dipart, eta, and dt columns in the current row of the DataTable
                    row("std1") = std
                    row("dipart") = dTime
                    row("eta") = eta
                    row("dt") = dt



                    'Close the reader
                    reader.Close()
                End If

                reader.Close()
            Next

            'Set the DataPropertyName of the std1 column
            DataGridView2.Columns("std1").DataPropertyName = "std1"
            DataGridView2.Columns("dipart").DataPropertyName = "dipart"
            DataGridView2.Columns("dt").DataPropertyName = "dt"
            DataGridView2.Columns("eta").DataPropertyName = "eta"

            'Set the DataSource of the DataGridView to a DataView of the DataTable
            DataGridView2.DataSource = table.DefaultView
            DataGridView2.AutoGenerateColumns = False

        Catch ex As Exception
            'Handle any exceptions that may occur
            MessageBox.Show("Error: " & ex.Message)
        Finally
            'Close the connection
            connsql.Close()
        End Try


    End Sub




    ' ===========================================> delete the crewmen table record 
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


    'flight details
    Private Sub btnsave1_Click(sender As Object, e As EventArgs) Handles btnsave1.Click
        Try

            'check whether all the fields are empty
            If String.IsNullOrEmpty(tbflightNo.Text) Then
                MsgBox("FILL The Field")
                tbflightNo.Focus()

            ElseIf String.IsNullOrEmpty(cbarlinecategory.Text) Then
                MsgBox("FILL The Field")
                cbarlinecategory.Focus()


            ElseIf String.IsNullOrEmpty(cbStd.Text) Then
                MsgBox("FILL The Field")
                cbStd.Focus()


            ElseIf String.IsNullOrEmpty(cbStd1.Text) Then
                MsgBox("FILL The Field")
                cbStd1.Focus()


            ElseIf String.IsNullOrEmpty(cbDT.Text) Then
                MsgBox("FILL The Field")
                cbDT.Focus()

            ElseIf String.IsNullOrEmpty(DateTimePicker1.Text) Then
                DateTimePicker1.Focus()


            Else

                'open database connection 

                connsql.Open()
                Dim fno As Integer
                fno = tbflightNo.Text


                Dim queryString As String = "SELECT COUNT(*) FROM FLIGHT_MASTER_TABLE WHERE Flight_No = @userInput1"
                Dim commandD As New SqlCommand(queryString, connsql)
                commandD.Parameters.AddWithValue("@userInput1", fno)
                Dim countC As Integer = Convert.ToInt32(commandD.ExecuteScalar())
                connsql.Close()


                If countC > 0 Then

                    MsgBox("fligh no already exists in database")

                Else

                    connsql.Open()
                    ' insert data to the database

                    Dim flightNo As Integer
                    Dim ACateogry As String
                    flightNo = Integer.Parse(tbflightNo.Text)
                    ACateogry = cbarlinecategory.Text

                    'insert flight no, airline code to the flight master table + generate fid


                    Dim sql As String = "INSERT INTO FLIGHT_MASTER_TABLE (Flight_No, Airline_Code) VALUES (@Flight_No, @Airline_Code)"
                    Dim command1 As New SqlCommand(sql, connsql)
                    command1.Parameters.AddWithValue("@Flight_No", flightNo)
                    command1.Parameters.AddWithValue("@Airline_Code", ACateogry)
                    command1.ExecuteNonQuery()

                    connsql.Close()

                    'retrieve fid 
                    Dim command2 As New SqlCommand("SELECT TOP 1 FID  FROM FLIGHT_MASTER_TABLE ORDER BY FID DESC", connsql)
                    connsql.Open()
                    Dim fid As String = command2.ExecuteScalar().ToString() '======================================================
                    connsql.Close()
                    'insert std,dep time,date to the flight time table



                    ' Create a query to retrieve the rows of the selected id from both tables
                    Dim query As String = "SELECT * FROM FLIGHT_MASTER_TABLE INNER JOIN FLIGHT_TIME_TABLE ON FLIGHT_MASTER_TABLE.FID = FLIGHT_TIME_TABLE.FID WHERE 
                                            FLIGHT_MASTER_TABLE.FID = @FID"

                    'Execute the query and retrieve the data into a DataTable object
                    Dim cmdd As New SqlCommand(query, connsql)
                    ' Dim selectId As New Integer
                    cmdd.Parameters.AddWithValue("@FID", lblSelectedID.Text)
                    Dim adapter As New SqlDataAdapter(cmdd)
                    ' Dim dataTable1 As New DataTable()
                    ' adapter.Fill(dataTable1)

                    ' DataGridView1.DataSource = dataTable1

                    'query = "SELECT COUNTI(*) FROM FLIGHT_MASTER_TABLE WHERE FID = @FID; SELECT COUNT(*) FROM FLIGHT_TIME_TABLE WHERE FID = @FID"

                    '  cmdd = New SqlCommand(query, connsql)
                    ' cmdd.Parameters.AddWithValue("@FID", lblSelectedID.Text)
                    ' connsql.Open()
                    ' Dim reader As SqlDataReader = cmdd.ExecuteReader()
                    ' reader.Read()
                    ' Dim count1 As Integer = reader.GetInt32(0)
                    ' reader.NextResult()
                    ' reader.Close()
                    ' Dim count2 As Integer = reader.GetInt32(0)
                    'reader.Close()

                    '7. Display the count value in a label or another suitable control
                    '                    Label1.Text = "Total Rows: " & (count1 + count2).ToString()

                    Dim std As String = cbStd.Text & ":" & cbStd1.Text & ":00"
                    Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
                    Dim stdTime As TimeSpan = dt.TimeOfDay '==========================================================> std

                    Dim dipT As String = cbDT.Text & ":00"
                    Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
                    Dim sTime As TimeSpan = dipTime.TimeOfDay

                    Dim eta As TimeSpan
                    If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                        eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
                    Else ' if the standard time is later than the dip time, subtract the two times
                        eta = stdTime - sTime
                    End If

                    Console.WriteLine("ETA: " & eta.ToString("hh\:mm\:ss")) ' output the ETA in the format hh:mm:ss



                    'MsgBox(eta.ToString("HH:mm"))

                    Dim dipartime As TimeSpan = TimeSpan.Parse(cbDT.Text) '==========================> [DIP TIME]

                    ' Get the selected date value from the DateTimePicker control
                    Dim selectedDate As DateTime = DateTimePicker1.Value    '======================> date


                    Dim sql1 As String = "INSERT INTO FLIGHT_TIME_TABLE (FID, STD, [DIP TIME], Date, ETA) values (@FID, @STD, @DIP, @Date, @ETA)"
                    connsql.Open()
                    Dim com As New SqlCommand(sql1, connsql)
                    com.Parameters.AddWithValue("@FID", fid)
                    com.Parameters.AddWithValue("@STD", stdTime)
                    com.Parameters.AddWithValue("@DIP", dipartime)
                    com.Parameters.AddWithValue("@Date", selectedDate)
                    com.Parameters.AddWithValue("@ETA", eta)
                    com.ExecuteNonQuery()

                    'connection close
                    connsql.Close()
                    MsgBox(" Successfully Added To The Table")

                    'load data to the grid


                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''>>>>>>>>>>>>>>>>>>
                    '''want to load data 
                    '''
                    loadToGrid1()

                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            connsql.Close()

        End Try

    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim selectedRow As DataGridViewRow = DataGridView2.CurrentRow

        ' Get the values of the cells in the selected row
        Dim Sid As Object = selectedRow.Cells(0).Value
        Dim flightNo As Object = selectedRow.Cells(1).Value
        Dim ACateogry As Object = selectedRow.Cells(2).Value
        'Dim std As Object = selectedRow.Cells(3).Value
        Dim std1 As Object = selectedRow.Cells(3).Value

        Dim selectedDate As Object = selectedRow.Cells(6).Value

        Dim std As TimeOnly = TimeOnly.Parse(selectedRow.Cells(3).Value.ToString())
        Dim hours As String = std.Hour().ToString("D2")
        Dim min As String = std.Minute().ToString("D2")


        Dim fullDip As TimeOnly = TimeOnly.Parse(selectedRow.Cells(4).Value.ToString())
        Dim dipH As String = fullDip.Hour().ToString("D2")
        Dim dipM As String = fullDip.Minute().ToString("D2")
        Dim dipartime As String = dipH & ":" & dipM

        ' Populate the form controls with the selected row data
        lbselectID.Text = Sid.ToString()
        tbflightNo.Text = flightNo.ToString()
        cbarlinecategory.Text = ACateogry.ToString()

        cbStd.Text = hours ' Get the time in hours
        cbStd1.Text = min ' Get the minutes

        cbDT.Text = dipartime.ToString()
        DateTimePicker1.Value = Date.Parse(selectedDate.ToString()) ' Set the date only to the DateTimePicker


    End Sub



    Public Sub loadAirlineCode()
        Try

            Dim cmd As New SqlCommand("SELECT Airline_Code FROM AIRLINE_MASTER_TABLE", connsql)
            connsql.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cbarlinecategory.Items.Add(reader("Airline_Code").ToString())
            End While

            reader.Close()
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub



    Private Sub cbarlinecategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbarlinecategory.SelectedIndexChanged
        Try
            connsql.Open()

            Dim cmd As New SqlCommand("SELECT Airline_Name FROM AIRLINE_MASTER_TABLE where Airline_Code = @cd ", connsql)

            cmd.Parameters.AddWithValue("@cd", cbarlinecategory.Text)
            Dim airline = cmd.ExecuteScalar()
            tbAirlines.Text = airline
            connsql.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ' ==========================> delete flight details
    Private Sub deleteFlight_Click(sender As Object, e As EventArgs) Handles deleteFlight.Click

        Try
            If String.IsNullOrWhiteSpace(lbselectID.Text) Then
                ' No ID selected
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.OKCancel)
                If result = DialogResult.OK Then
                    connsql.Open()
                    Using transaction As SqlTransaction = connsql.BeginTransaction()
                        Try
                            Dim cmd As New SqlCommand()
                            cmd.Connection = connsql
                            cmd.Transaction = transaction

                            cmd.CommandText = "DELETE FROM FLIGHT_MASTER_TABLE WHERE FID = @FID"
                            cmd.Parameters.AddWithValue("@FID", lbselectID.Text)
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "DELETE FROM FLIGHT_TIME_TABLE WHERE FID = @FID"
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MsgBox("Record deleted successfully.")
                        Catch ex As SqlException
                            transaction.Rollback()
                            MsgBox("SQL Error occurred: " & ex.Message)
                        Catch ex As Exception
                            transaction.Rollback()
                            MsgBox("SQL Error occurred: " & ex.Message)
                        End Try
                    End Using
                    connsql.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("SQL Error occurred: " & ex.Message)
        End Try


        loadToGrid1()


    End Sub



    '========================================> Update flight details
    Private Sub updateFlight_Click(sender As Object, e As EventArgs) Handles updateFlight.Click

        ' Open database connection 
        connsql.Open()

        Using transaction1 As SqlTransaction = connsql.BeginTransaction()
            Try
                ' Create command object
                Dim cmd As New SqlCommand()
                cmd.Connection = connsql
                cmd.Transaction = transaction1
                cmd.CommandType = CommandType.Text

                ' Update first table
                cmd.CommandText = "UPDATE FLIGHT_MASTER_TABLE SET Flight_No = @Flight_No,Airline_Code = @Airline_Code  WHERE FID = @FID"

                cmd.Parameters.AddWithValue("@FID", lbselectID.Text)
                cmd.Parameters.AddWithValue("@Flight_No", tbflightNo.Text)
                cmd.Parameters.AddWithValue("@Airline_Code", cbarlinecategory.Text)

                cmd.ExecuteNonQuery()

                ' Update second table
                cmd.CommandText = "UPDATE FLIGHT_TIME_TABLE SET STD = @STD,[DIP TIME] = @DIP , Date = @Date, ETA = @ETA  WHERE FID = @FID"

                ' Clear parameters from previous command
                cmd.Parameters.Clear()

                ' Add parameters for second command
                Dim std As String = cbStd.Text & ":" & cbStd1.Text & ":00"
                Dim dt As DateTime = DateTime.ParseExact(std, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim stdTime As TimeSpan = dt.TimeOfDay
                Dim dipT As String = cbDT.Text & ":00"
                Dim dipTime As DateTime = DateTime.ParseExact(dipT, "HH:mm:ss", CultureInfo.InvariantCulture)
                Dim sTime As TimeSpan = dipTime.TimeOfDay
                'Dim eta As TimeSpan = stdTime - sTime
                Dim dipartime As TimeSpan = TimeSpan.Parse(cbDT.Text)
                Dim selectedDate As DateTime = DateTimePicker1.Value

                Dim eta As TimeSpan
                If stdTime <= sTime Then ' if the standard time is earlier or the same as the dip time, add 1 day to the std time
                    eta = stdTime.Add(TimeSpan.FromDays(1)) - sTime
                Else ' if the standard time is later than the dip time, subtract the two times
                    eta = stdTime - sTime
                End If

                Console.WriteLine("ETA: " & eta.ToString("hh\:mm\:ss")) ' output the ETA in the format hh:mm:ss




                cmd.Parameters.AddWithValue("@FID", lbselectID.Text)
                cmd.Parameters.AddWithValue("@STD", stdTime)
                cmd.Parameters.AddWithValue("@DIP", dipartime)
                cmd.Parameters.AddWithValue("@Date", selectedDate)
                cmd.Parameters.AddWithValue("@ETA", eta)

                cmd.ExecuteNonQuery()

                ' Commit transaction if all commands succeed
                transaction1.Commit()

                ' Show success message
                Dim result As DialogResult = MessageBox.Show("Do you want to change ?", "Update Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    ' User clicked Yes
                    MsgBox("Successfully Updated ")
                End If
                connsql.Close()
                loadToGrid1()
            Catch ex As Exception
                ' Roll back the transaction if any error occurs
                transaction1.Rollback()
                MsgBox(ex.Message)
            End Try
        End Using

        ' Close the connection
        connsql.Close()


    End Sub
End Class