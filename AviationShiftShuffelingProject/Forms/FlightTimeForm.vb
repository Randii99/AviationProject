
Imports FontAwesome.Sharp




Public Class FlightTimeForm
    Private Sub CrewAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim icon As IconChar = IconChar.Add
        Dim btnAdd As New IconButton()
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.TextAlign = ContentAlignment.MiddleCenter
        btnAdd.Left = 163
        btnAdd.Top = 220
        btnAdd.IconChar = icon
        btnAdd.Text = "ADD"
        btnAdd.IconSize = 16


        btnAdd.Height = 35
        btnAdd.Width = 120





        Me.Controls.Add(btnAdd)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class