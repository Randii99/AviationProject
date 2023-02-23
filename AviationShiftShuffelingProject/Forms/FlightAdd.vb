
Imports FontAwesome.Sharp



Public Class FlightAdd
    Private Sub cbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroup.SelectedIndexChanged


        Dim icon As IconChar = IconChar.Add
        Dim btn1Add As New IconButton()
        btn1Add.TextImageRelation = TextImageRelation.ImageBeforeText
        btn1Add.TextAlign = ContentAlignment.MiddleCenter
        btn1Add.Left = 163
        btn1Add.Top = 220
        btn1Add.IconChar = icon
        btn1Add.Text = "ADD"
        btn1Add.IconSize = 16


        btn1Add.Height = 35
        btn1Add.Width = 120





        Me.Controls.Add(btn1Add)
    End Sub
End Class