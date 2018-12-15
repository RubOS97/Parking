Public Class Main

	Public planta1 As ArrayList = New ArrayList
	Public planta2 As ArrayList = New ArrayList
	Public planta3 As ArrayList = New ArrayList

	Public aparcado As ArrayList = New ArrayList

	Public p1Coches As Integer = 7
	Public p1Motos As Integer = 3
	Public p2Coches As Integer = 7
	Public p2Motos As Integer = 3
	Public p3Coches As Integer = 7
	Public p3Motos As Integer = 3

	Public hEntrada As String = 0
	Public hSalida As String = 0

	Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'CREACION DE LAS PLAZAS DE PARKING'
		'PLANTA 1'
		For i As Integer = 1 To 7
			Dim p As Plaza = New Plaza("", True, "", True)
			planta1.Add(p)
		Next
		For i As Integer = 1 To 3
			Dim p As Plaza = New Plaza("", False, "", True)
			planta1.Add(p)
		Next

		'PLANTA 2'
		For i As Integer = 1 To 7
			Dim p As Plaza = New Plaza("", True, "", True)
			planta2.Add(p)
		Next
		For i As Integer = 1 To 3
			Dim p As Plaza = New Plaza("", False, "", True)
			planta2.Add(p)
		Next

		'PLANTA 3'
		For i As Integer = 1 To 7
			Dim p As Plaza = New Plaza("", True, "", True)
			planta3.Add(p)
		Next
		For i As Integer = 1 To 3
			Dim p As Plaza = New Plaza("", False, "", True)
			planta3.Add(p)
		Next

		CalendarHoraEntrada.CustomFormat = ("HH:mm")
		CalendarHoraSalida.CustomFormat = ("HH:mm")
		CalendarHoraEntrada.Format = DateTimePickerFormat.Custom
		CalendarHoraSalida.Format = DateTimePickerFormat.Custom
		CalendarHoraSalida.ShowUpDown = True
		CalendarHoraEntrada.ShowUpDown = True

		'INICIO'
		ActualizarMarcadores()

	End Sub

	Private Sub BtnEntrada_Click(sender As Object, e As EventArgs)
		Dim intent As Entrada_Vehiculo = New Entrada_Vehiculo
		intent.Show()
	End Sub

	Private Sub BtnSalida_Click(sender As Object, e As EventArgs)
		Dim intent As Salida_Vehiculo = New Salida_Vehiculo
		intent.Show()
	End Sub

	Private Sub BtnFijarPrecio_Click(sender As Object, e As EventArgs)
		Dim intent As Fijar_Precio = New Fijar_Precio
		intent.Show()
	End Sub

	Private Sub BtnSacarCuentas_Click(sender As Object, e As EventArgs)
		Dim intent As Sacar_Cuentas = New Sacar_Cuentas
		intent.Show()
	End Sub

	Private Sub BtnGestion_Click(sender As Object, e As EventArgs)
		Dim intent As Gestion_Gastos = New Gestion_Gastos
		intent.Show()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		System.Environment.Exit(1)
	End Sub

	Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
		CalendarHoraEntrada.CustomFormat = ("HH:mm")
		CalendarHoraEntrada.Format = DateTimePickerFormat.Custom
		CalendarHoraEntrada.ShowUpDown = True
	End Sub

	Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
		Dim p As Plaza = New Plaza("", False, "", True)
		p.Matricula1 = TxtMatricula.Text
		If CheckCoche.Checked Then
			p.Tipo1 = True
		End If
		If CheckMoto.Checked Then
			p.Tipo1 = False
		End If
		p.Estado1 = False
		p.Hora1 = CalendarHoraEntrada.Value.ToString("HH") & " : " & CalendarHoraEntrada.Value.ToString("mm")

		If (EntrarVehiculo(p)) Then
			MsgBox("Vehiculo Aparcado")
			'ListarParking()
		Else
			MsgBox("Parking Lleno")
		End If
		ActualizarMarcadores()
		LimpiarForm()
	End Sub

	'LIMPIA EL FORMULARIO
	Private Sub LimpiarForm()
		TxtMatricula.Text = ""
		CheckCoche.CheckState = CheckState.Unchecked
		CheckMoto.CheckState = CheckState.Unchecked
		CheckMoto.Show()
		CheckCoche.Show()
	End Sub

	'METODO PARA LISTAR PARKING (solo comprovaciones)
	Private Sub ListarParking()
		For Each p As Plaza In planta1
			MsgBox(p.Matricula1)
		Next

		For Each p As Plaza In planta2
			MsgBox(p.Matricula1)
		Next

		For Each p As Plaza In planta3
			MsgBox(p.Matricula1)
		Next
	End Sub

	Private Function EntrarVehiculo(vehiculo As Plaza)
		For Each p As Plaza In planta1
			If vehiculo.Tipo1 = True Then
				If p1Coches = 0 Then
					Exit For
				Else
					If (p.Tipo1 = True) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p1Coches -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			Else
				If p1Motos = 0 Then
					Exit For
				Else
					If (p.Tipo1 = False) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p1Motos -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			End If
		Next

		For Each p As Plaza In planta2
			If vehiculo.Tipo1 = True Then
				If p2Coches = 0 Then
					Exit For
				Else
					If (p.Tipo1 = True) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p2Coches -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			Else
				If p2Motos = 0 Then
					Exit For
				Else
					If (p.Tipo1 = False) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p2Motos -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			End If
		Next

		For Each p As Plaza In planta3
			If vehiculo.Tipo1 = True Then
				If p3Coches = 0 Then
					Exit For
				Else
					If (p.Tipo1 = True) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p3Coches -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			Else
				If p3Motos = 0 Then
					Exit For
				Else
					If (p.Tipo1 = False) Then
						If p.Estado1 = True Then
							p.Matricula1 = vehiculo.Matricula1
							p.Estado1 = vehiculo.Estado1
							p.Hora1 = vehiculo.Hora1
							p3Motos -= 1
							ComboMatricula.Items.Add(p.Matricula1)
							Return True
							Exit Function
						End If
					End If
				End If
			End If
		Next
		Return False
	End Function

	'Actualiza marcadores del parking
	Private Sub ActualizarMarcadores()
		LblPlanta1.Text = p1Coches
		LblTotal1.Text = p1Motos

		LblPlanta2.Text = p2Coches
		LblTotal2.Text = p2Motos

		LblPlanta3.Text = p3Coches
		LblTotal3.Text = p3Motos
	End Sub

	'Actualiza precio de salida
	Private Sub ActualizaPrecio()
		Dim precio As Integer = 0
		If String.Compare(hEntrada, "0") <> 0 Then
			Dim auxHEntrada As Integer = hEntrada.Substring(0, 2)
			Dim auxMEntrada As Integer = hEntrada.Substring(4, 2)

			Dim hEnt As Integer = (auxHEntrada * 60) + auxMEntrada

			Dim auxHSalida As Integer = hSalida.Substring(0, 2)
			Dim auxMSalida As Integer = hSalida.Substring(4, 2)
			Dim hSal As Integer = (auxHSalida * 60) + auxMSalida

			precio = (hSal - hEnt) / 30

			LblPrecio.Text = precio & "€"
		End If

	End Sub

	'Cambian fotos de las camaras
	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		PicCamara.Image = My.Resources.ParkingCamera01
	End Sub

	Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
		PicCamara.Image = My.Resources.parking_02
	End Sub

	Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
		PicCamara.Image = My.Resources.parking_03
	End Sub

	Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
		PicCamara.Image = My.Resources.parking_04
	End Sub

	Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
		PicCamara.Image = My.Resources.parking_05
	End Sub

	Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
		PicCamara.Image = My.Resources.parking_06
	End Sub

	Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
		PicCamara.Image = My.Resources.parking_07
	End Sub

	Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
		PicCamara.Image = My.Resources.parking_08
	End Sub

	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		ActualizarMarcadores()
		SacarVehiculo()
	End Sub

	Private Sub SacarVehiculo()
		Dim p As Plaza = BuscaVehiculo(ComboMatricula.SelectedItem.ToString)
		p.Estado1 = True
		If p.Tipo1 = True Then
			p1Coches = p1Coches + 1
		Else
			p1Motos = p1Motos + 1
		End If
		ComboMatricula.Items.Remove(p.Matricula1)
		ActualizarMarcadores()
	End Sub

	Private Sub ComboMatricula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMatricula.SelectedIndexChanged
		Dim p As Plaza
		p = BuscaVehiculo(ComboMatricula.SelectedItem.ToString)
		TxtHoraEntrada.Text = p.Hora1
		hEntrada = p.Hora1
	End Sub

	Private Sub CalendarHoraSalida_ValueChanged(sender As Object, e As EventArgs) Handles CalendarHoraSalida.ValueChanged
		Dim aux As String = CalendarHoraSalida.Value.ToString("HH") & " : " & CalendarHoraSalida.Value.ToString("mm")
		hSalida = aux
		ActualizaPrecio()
	End Sub

	Private Function BuscaVehiculo(matricula As String) As Plaza
		For Each p As Plaza In planta1
			If String.Compare(p.Matricula1, matricula) = 0 Then
				Return p
			End If
		Next

		For Each p As Plaza In planta2
			If String.Compare(p.Matricula1, matricula) = 0 Then
				Return p
			End If
		Next

		For Each p As Plaza In planta3
			If String.Compare(p.Matricula1, matricula) = 0 Then
				Return p
			End If
		Next
		Return Nothing
	End Function

	Private Sub CheckCoche_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCoche.CheckedChanged
		CheckMoto.Hide()
	End Sub

	Private Sub CheckMoto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMoto.CheckedChanged
		CheckMoto.Hide()
	End Sub

	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
		LimpiarForm()
	End Sub
End Class
