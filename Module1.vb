Imports System.Linq
Module Module1

    Sub Main()
        Dim productos = genereListado()
        Debug.WriteLine("-- ordenar los productos: --")
        Dim productosOrdenados = (From prod In productos
                                  Order By prod.Nombre).ToList()
        mostrarProductos(productosOrdenados)
        Debug.WriteLine("-- filtrado por categoria (bebida): --")
        Dim productosFiltrados = (From prod In productos
                                  Where prod.Categoria = "bebida").ToList()
        mostrarProductos(productosFiltrados)
        Debug.WriteLine("-- filtrado por categoria (bebida) y ademas por precio mayor a 20: --")

        Dim productosFiltrados2 = (From prod In productos
                                   Where prod.Categoria = "bebida"
                                   Where prod.Precio > 20).ToList()
        mostrarProductos(productosFiltrados2)
    End Sub
    Sub mostrarProductos(productos As List(Of Producto))
        productos.ForEach(Sub(producto) Debug.WriteLine($"{producto.Nombre} | {producto.Precio} | {producto.Cantidad} | {producto.Categoria}"))
    End Sub
    Function genereListado() As List(Of Producto)
        Dim productos As New List(Of Producto)
        productos.Add(New Producto("cocacola", 10, 30, "bebida"))
        productos.Add(New Producto("fanta", 30, 10, "bebida"))
        productos.Add(New Producto("sprite", 20, 50, "bebida"))
        productos.Add(New Producto("samsung", 400, 20, "tecnologia"))
        productos.Add(New Producto("apple", 300, 5, "tecnologia"))
        productos.Add(New Producto("microsoft", 500, 2, "tecnologia"))
        Return productos
    End Function

End Module
