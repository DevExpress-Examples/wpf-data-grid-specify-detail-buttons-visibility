Imports System.Collections.Generic

Namespace WpfApplication26

    Public Class Category

        Public Sub New(ByVal name As String)
            Me.Name = name
            Products = New List(Of Product)()
        End Sub

        Public Property Name As String

        Public ReadOnly Property Products As List(Of Product)
    End Class

    Public Class Product

        Public Sub New(ByVal name As String, ByVal price As Double)
            Me.Name = name
            Me.Price = price
        End Sub

        Public Property Name As String

        Public Property Price As Double
    End Class

    Public Class DataSource

        Public Shared Function GetCategories() As List(Of Category)
            Dim categories = New List(Of Category)()
            categories.Add(New Category("First"))
            categories(0).Products.Add(New Product("Product 1.1", 10))
            categories(0).Products.Add(New Product("Product 1.2", 20))
            categories(0).Products.Add(New Product("Product 1.3", 30))
            categories(0).Products.Add(New Product("Product 1.4", 40))
            categories.Add(New Category("Second"))
            categories(1).Products.Add(New Product("Product 2.1", 10))
            categories(1).Products.Add(New Product("Product 2.2", 20))
            categories.Add(New Category("Third"))
            categories(2).Products.Add(New Product("Product 3.1", 10))
            categories(2).Products.Add(New Product("Product 3.2", 20))
            categories(2).Products.Add(New Product("Product 3.4", 40))
            categories.Add(New Category("Fourth"))
            categories(3).Products.Add(New Product("Product 4.1", 10))
            categories(3).Products.Add(New Product("Product 4.2", 20))
            categories(3).Products.Add(New Product("Product 4.3", 30))
            categories(3).Products.Add(New Product("Product 4.4", 40))
            Return categories
        End Function

        Public ReadOnly Property Categories As List(Of Category)
    End Class
End Namespace
