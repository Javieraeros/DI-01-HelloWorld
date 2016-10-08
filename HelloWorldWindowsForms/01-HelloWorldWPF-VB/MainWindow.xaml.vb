Class MainWindow
    ''' <summary>
    ''' funcionalidad que al clickar el botón nos muestra un hola mundo con el nombre
    ''' de la persona y Buenos días, Buenas tardes o Buenas noches dependiendo de la hora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <pre>Ninguna</pre>
    ''' <post>Mostrará en un cuadro de texto el hola más le nombre más los buenos ....</post>
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim nombre As String = txtNombre.Text
        Dim fecha As String
        Dim bi3 As New BitmapImage
        If (Date.Now.Hour >= 6 And Date.Now.Hour < 12) Then
            fecha = "buenos días"
            bi3.BeginInit()
            bi3.UriSource = New Uri("C:\Users\fjrodriguez\Downloads\mañana.jpg")
            bi3.EndInit()
        ElseIf (Date.Now.Hour >= 12 And Date.Now.Hour < 22) Then
            fecha = "buenas tardes"
            bi3.BeginInit()
            bi3.UriSource = New Uri("C:\Users\fjrodriguez\Downloads\tarde.jpg")
            bi3.EndInit()
        Else
            fecha = "buenas noches"
            bi3.BeginInit()
            bi3.UriSource = New Uri("C:\Users\fjrodriguez\Downloads\noche.jpg")
            bi3.EndInit()
        End If
        imagen.Source = bi3
        muestraNombre.Text = "Hola " + nombre + "," + fecha
    End Sub
End Class
