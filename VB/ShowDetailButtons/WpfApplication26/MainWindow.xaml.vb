Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Globalization

Namespace WpfApplication26

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid1.ItemsSource = New DataSource().Categories
        End Sub
    End Class

    <ValueConversion(GetType(Object), GetType(Boolean))>
    Public Class MyConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            ' Obtaining the value to be converted 
            Dim categoryValue As String = CStr(value)
            ' Specifying values for which to show expand buttons
            Dim categories As String() = New String() {"First", "Third"}
            If categories.Contains(categoryValue) Then Return True
            ' Disable expand button if the value isn't in the list
            Return False
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function
    End Class
End Namespace
