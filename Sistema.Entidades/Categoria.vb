﻿Public Class Categoria
#Region "Atributos"
    Private _Idcategoria As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Estado As Boolean
#End Region

#Region "Propiedades"
    Public Property Idcategoria As Integer
        Get
            Return _Idcategoria
        End Get
        Set(value As Integer)
            _Idcategoria = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _Estado
        End Get
        Set(value As Boolean)
            _Estado = value
        End Set
    End Property
#End Region

End Class
