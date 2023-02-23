
Imports FontAwesome.Sharp




Public Class CrewAddForm
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
End Class