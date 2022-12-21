Imports System.Collections.Generic

Namespace WpfApplication26

    Public Class Category

        Private nameField As String

        Private productsField As List(Of Product)

        Public Sub New(ByVal name As String)
            nameField = name
            productsField = New List(Of Product)()
        End Sub

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                nameField = value
            End Set
        End Property

        Public ReadOnly Property Products As List(Of Product)
            Get
                Return productsField
            End Get
        End Property
    End Class

    Public Class Product

        Private nameField As String

        Private priceField As Double

        Public Sub New(ByVal name As String, ByVal price As Double)
            nameField = name
            priceField = price
        End Sub

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                nameField = value
            End Set
        End Property

        Public Property Price As Double
            Get
                Return priceField
            End Get

            Set(ByVal value As Double)
                priceField = value
            End Set
        End Property
    End Class

    Public Class DataSource

        Private categoriesField As List(Of Category)

        Public Sub New()
            categoriesField = New List(Of Category)()
            categoriesField.Add(New Category("First"))
            categoriesField(0).Products.Add(New Product("Product 1.1", 10))
            categoriesField(0).Products.Add(New Product("Product 1.2", 20))
            categoriesField(0).Products.Add(New Product("Product 1.3", 30))
            categoriesField(0).Products.Add(New Product("Product 1.4", 40))
            categoriesField.Add(New Category("Second"))
            categoriesField(1).Products.Add(New Product("Product 2.1", 10))
            categoriesField(1).Products.Add(New Product("Product 2.2", 20))
            categoriesField.Add(New Category("Third"))
            categoriesField(2).Products.Add(New Product("Product 3.1", 10))
            categoriesField(2).Products.Add(New Product("Product 3.2", 20))
            categoriesField(2).Products.Add(New Product("Product 3.4", 40))
            categoriesField.Add(New Category("Fourth"))
            categoriesField(3).Products.Add(New Product("Product 4.1", 10))
            categoriesField(3).Products.Add(New Product("Product 4.2", 20))
            categoriesField(3).Products.Add(New Product("Product 4.3", 30))
            categoriesField(3).Products.Add(New Product("Product 4.4", 40))
        End Sub

        Public ReadOnly Property Categories As List(Of Category)
            Get
                Return categoriesField
            End Get
        End Property
    End Class
End Namespace
