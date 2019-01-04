Public Class ConversorBorde
    Implements IValueConverter

    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object,
                            ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert

        If value Then
            Return 1
        Else
            Return 0
        End If

    End Function


    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object,
                                ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function

End Class
