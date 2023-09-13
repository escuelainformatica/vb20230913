Public Class Producto
    Public Property Nombre As String
    Public Property Precio As Integer
    Public Property Cantidad As Integer
    Public Property Categoria As String
    Public Sub New()

    End Sub

    ' constructor.
    Public Sub New(nombre As String, precio As Integer, Optional Cantidad As Integer = 0, Optional Categoria As String = "SIN")
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Cantidad = Cantidad
        Me.Categoria = Categoria
    End Sub
End Class
