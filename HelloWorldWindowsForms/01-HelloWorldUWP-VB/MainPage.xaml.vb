' La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub boton_Click(sender As Object, e As RoutedEventArgs) Handles boton.Click
        Dim nomb As String = nombre.Text
        Dim fecha As String
        If (Date.Now.Hour >= 6 And Date.Now.Hour < 12) Then
            fecha = "buenos días"
        ElseIf (Date.Now.Hour >= 12 And Date.Now.Hour < 22) Then
            fecha = "buenas tardes"
        Else
            fecha = "buenas noches"
        End If
        muestranombre.Text = "Hola " + nomb + "," + fecha
    End Sub
End Class
