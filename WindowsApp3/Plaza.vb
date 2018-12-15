Public Class Plaza
	Dim matricula As String
	Dim tipo As Boolean
	Dim hora As String
	Dim estado As Boolean

	Public Sub New(matricula As String, tipo As Boolean, hora As String, estado As Boolean)
		Me.matricula = matricula
		Me.tipo = tipo
		Me.hora = hora
		Me.estado = estado
	End Sub

	Public Property Matricula1 As String
		Get
			Return matricula
		End Get
		Set(value As String)
			matricula = value
		End Set
	End Property

	Public Property Tipo1 As Boolean
		Get
			Return tipo
		End Get
		Set(value As Boolean)
			tipo = value
		End Set
	End Property

	Public Property Hora1 As String
		Get
			Return hora
		End Get
		Set(value As String)
			hora = value
		End Set
	End Property

	Public Property Estado1 As Boolean
		Get
			Return estado
		End Get
		Set(value As Boolean)
			estado = value
		End Set
	End Property
End Class
