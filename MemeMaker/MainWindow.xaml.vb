Class MainWindow
    Private Sub SeleccionarButton_Click(sender As Object, e As RoutedEventArgs)
        Dim dlg As New Microsoft.Win32.OpenFileDialog()
        Dim result As Boolean = dlg.ShowDialog()

        If result = True Then
            MemeDockPanel.Background = New ImageBrush(New BitmapImage(New Uri(dlg.FileName)))
        End If
    End Sub
End Class
