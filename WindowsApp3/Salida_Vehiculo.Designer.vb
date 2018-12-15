<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida_Vehiculo
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtMatricula = New System.Windows.Forms.TextBox()
		Me.TxtHoraEntrada = New System.Windows.Forms.TextBox()
		Me.TxtPlaza = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TxtHoraSalida = New System.Windows.Forms.TextBox()
		Me.BtnImprimir = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.LblPrecio = New System.Windows.Forms.Label()
		Me.BtnAceptar = New System.Windows.Forms.Button()
		Me.BtnCancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(222, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(365, 42)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "SALIDA VEHICULO"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(226, 171)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Hora entrada"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(226, 280)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "Matrícula"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(226, 120)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(33, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Plaza"
		'
		'TxtMatricula
		'
		Me.TxtMatricula.Location = New System.Drawing.Point(229, 296)
		Me.TxtMatricula.Name = "TxtMatricula"
		Me.TxtMatricula.Size = New System.Drawing.Size(345, 20)
		Me.TxtMatricula.TabIndex = 12
		'
		'TxtHoraEntrada
		'
		Me.TxtHoraEntrada.Location = New System.Drawing.Point(229, 187)
		Me.TxtHoraEntrada.Name = "TxtHoraEntrada"
		Me.TxtHoraEntrada.Size = New System.Drawing.Size(345, 20)
		Me.TxtHoraEntrada.TabIndex = 11
		'
		'TxtPlaza
		'
		Me.TxtPlaza.Location = New System.Drawing.Point(229, 136)
		Me.TxtPlaza.Name = "TxtPlaza"
		Me.TxtPlaza.Size = New System.Drawing.Size(345, 20)
		Me.TxtPlaza.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(226, 227)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(60, 13)
		Me.Label6.TabIndex = 20
		Me.Label6.Text = "Hora salida"
		'
		'TxtHoraSalida
		'
		Me.TxtHoraSalida.Location = New System.Drawing.Point(229, 243)
		Me.TxtHoraSalida.Name = "TxtHoraSalida"
		Me.TxtHoraSalida.Size = New System.Drawing.Size(345, 20)
		Me.TxtHoraSalida.TabIndex = 19
		'
		'BtnImprimir
		'
		Me.BtnImprimir.Location = New System.Drawing.Point(499, 98)
		Me.BtnImprimir.Name = "BtnImprimir"
		Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
		Me.BtnImprimir.TabIndex = 21
		Me.BtnImprimir.Text = "Imprimir"
		Me.BtnImprimir.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(225, 352)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(86, 20)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "PRECIO: "
		'
		'LblPrecio
		'
		Me.LblPrecio.AutoSize = True
		Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPrecio.Location = New System.Drawing.Point(343, 352)
		Me.LblPrecio.Name = "LblPrecio"
		Me.LblPrecio.Size = New System.Drawing.Size(39, 20)
		Me.LblPrecio.TabIndex = 23
		Me.LblPrecio.Text = "12€"
		'
		'BtnAceptar
		'
		Me.BtnAceptar.Location = New System.Drawing.Point(346, 395)
		Me.BtnAceptar.Name = "BtnAceptar"
		Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.BtnAceptar.TabIndex = 29
		Me.BtnAceptar.Text = "Aceptar"
		Me.BtnAceptar.UseVisualStyleBackColor = True
		'
		'BtnCancelar
		'
		Me.BtnCancelar.Location = New System.Drawing.Point(229, 395)
		Me.BtnCancelar.Name = "BtnCancelar"
		Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.BtnCancelar.TabIndex = 28
		Me.BtnCancelar.Text = "Cancelar"
		Me.BtnCancelar.UseVisualStyleBackColor = True
		'
		'Salida_Vehiculo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.BtnAceptar)
		Me.Controls.Add(Me.BtnCancelar)
		Me.Controls.Add(Me.LblPrecio)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.BtnImprimir)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TxtHoraSalida)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtMatricula)
		Me.Controls.Add(Me.TxtHoraEntrada)
		Me.Controls.Add(Me.TxtPlaza)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Salida_Vehiculo"
		Me.Text = "Salida_Vehiculo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtMatricula As TextBox
	Friend WithEvents TxtHoraEntrada As TextBox
	Friend WithEvents TxtPlaza As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents TxtHoraSalida As TextBox
	Friend WithEvents BtnImprimir As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents LblPrecio As Label
	Friend WithEvents BtnAceptar As Button
	Friend WithEvents BtnCancelar As Button
End Class
