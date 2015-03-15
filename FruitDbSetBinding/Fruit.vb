Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

''' <summary>
''' Code First Fruit class that represents the [Fruit] table in the database.
''' </summary>
''' <remarks>
''' Explicitly telling the context that we want the table named "Fruit", because,
''' depending on how this was set up, it might be looking for table "Fruits"
''' </remarks>
<Table("Fruit")>
Public Class Fruit
    Private _Id As Integer
    <Key>
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _FruitName As String
    Public Property FruitName() As String
        Get
            Return _FruitName
        End Get
        Set(ByVal value As String)
            _FruitName = value
        End Set
    End Property

    Private _FruitColor As String
    Public Property FruitColor() As String
        Get
            Return _FruitColor
        End Get
        Set(ByVal value As String)
            _FruitColor = value
        End Set
    End Property

    Private _FruitGrowsOn As Integer?
    Public Property FruitGrowsOn() As Integer?
        Get
            Return _FruitGrowsOn
        End Get
        Set(ByVal value As Integer?)
            _FruitGrowsOn = value
        End Set
    End Property

    Private _FruitIsYummy As Boolean?
    Public Property FruitIsYummy() As Boolean?
        Get
            Return _FruitIsYummy
        End Get
        Set(ByVal value As Boolean?)
            _FruitIsYummy = value
        End Set
    End Property

End Class
