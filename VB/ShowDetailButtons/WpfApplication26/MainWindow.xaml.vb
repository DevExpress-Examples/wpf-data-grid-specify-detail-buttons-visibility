Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Globalization

Namespace WpfApplication26
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid1.ItemsSource = New DataSource().Categories

		End Sub
	End Class

	<ValueConversion(GetType(Object), GetType(Boolean))> _
	Public Class MyConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			' Obtaining the value to be converted 
			Dim categoryValue As String = CStr(value)

			' Specifying values for which to show expand buttons
			Dim categories() As String = { "First", "Third" }
			If categories.Contains(categoryValue) Then
				Return True
			End If

			' Disable expand button if the value isn't in the list
			Return False
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
	End Class
End Namespace
