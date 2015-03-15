Imports System.Data.Entity
Imports System.Data.SqlClient

Public Class FruitContext
    Inherits DbContext

    Private _FruitDbSet As DbSet(Of Fruit)
    Public Property FruitDbSet() As DbSet(Of Fruit)
        Get
            Return _FruitDbSet
        End Get
        Set(ByVal value As DbSet(Of Fruit))
            _FruitDbSet = value
        End Set
    End Property

    ''' <summary>
    ''' Giving the context a connection string in the base constructor 
    ''' so it will not generate its own
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        MyBase.New("Data Source=(localdb)\v11.0;Initial Catalog=Fruit;Integrated Security=True")

        'This tells EF not to create a database, I already have one, thank you.
        Entity.Database.SetInitializer(Of FruitContext)(Nothing)

    End Sub

End Class
