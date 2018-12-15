<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada_Vehiculo
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
		Me.TxtPlaza = New System.Windows.Forms.TextBox()
		Me.TxtHoraEntrada = New System.Windows.Forms.TextBox()
		Me.TxtMatricula = New System.Windows.Forms.TextBox()
		Me.CheckCoche = New System.Windows.Forms.CheckBox()
		Me.CheckMoto = New System.Windows.Forms.CheckBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.BtnAceptar = New System.Windows.Forms.Button()
		Me.BtnCancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(171, 45)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(383, 39)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "ENTRADA VEHICULO"
		'
		'TxtPlaza
		'
		Me.TxtPlaza.Location = New System.Drawing.Point(190, 131)
		Me.TxtPlaza.Name = "TxtPlaza"
		Me.TxtPlaza.Size = New System.Drawing.Size(345, 20)
		Me.TxtPlaza.TabIndex = 1
		'
		'TxtHoraEntrada
		'
		Me.TxtHoraEntrada.Location = New System.Drawing.Point(190, 182)
		Me.TxtHoraEntrada.Name = "TxtHoraEntrada"
		Me.TxtHoraEntrada.Size = New System.Drawing.Size(345, 20)
		Me.TxtHoraEntrada.TabIndex = 2
		'
		'TxtMatricula
		'
		Me.TxtMatricula.Location = New System.Drawing.Point(190, 235)
		Me.TxtMatricula.Name = "TxtMatricula"
		Me.TxtMatricula.Size = New System.Drawing.Size(345, 20)
		Me.TxtMatricula.TabIndex = 3
		'
		'CheckCoche
		'
		Me.CheckCoche.AutoSize = True
		Me.CheckCoche.Location = New System.Drawing.Point(190, 309)
		Me.CheckCoche.Name = "CheckCoche"
		Me.CheckCoche.Size = New System.Drawing.Size(57, 17)
		Me.CheckCoche.TabIndex = 4
		Me.CheckCoche.Text = "Coche"
		Me.CheckCoche.UseVisualStyleBackColor = True
		'
		'CheckMoto
		'
		Me.CheckMoto.AutoSize = True
		Me.CheckMoto.Location = New System.Drawing.Point(307, 309)
		Me.CheckMoto.Name = "CheckMoto"
		Me.CheckMoto.Size = New System.Drawing.Size(50, 17)
		Me.CheckMoto.TabIndex = 5
		Me.CheckMoto.Text = "Moto"
		Me.CheckMoto.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(187, 115)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(33, 13)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Plaza"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(187, 219)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(52, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Matrícula"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(187, 166)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Hora entrada"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(187, 280)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(89, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Tipo de Vehículo"
		'
		'BtnAceptar
		'
		Me.BtnAceptar.Location = New System.Drawing.Point(402, 354)
		Me.BtnAceptar.Name = "BtnAceptar"
		Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.BtnAceptar.TabIndex = 29
		Me.BtnAceptar.Text = "Aceptar"
		Me.BtnAceptar.UseVisualStyleBackColor = True
		'
		'BtnCancelar
		'
		Me.BtnCancelar.Location = New System.Drawing.Point(251, 354)
		Me.BtnCancelar.Name = "BtnCancelar"
		Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.BtnCancelar.TabIndex = 28
		Me.BtnCancelar.Text = "Cancelar"
		Me.BtnCancelar.UseVisualStyleBackColor = True
		'
		'Entrada_Vehiculo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(722, 444)
		Me.Controls.Add(Me.BtnAceptar)
		Me.Controls.Add(Me.BtnCancelar)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.CheckMoto)
		Me.Controls.Add(Me.CheckCoche)
		Me.Controls.Add(Me.TxtMatricula)
		Me.Controls.Add(Me.TxtHoraEntrada)
		Me.Controls.Add(Me.TxtPlaza)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Entrada_Vehiculo"
		Me.Text = "Entrada_Vehiculo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents TxtPlaza As TextBox
	Friend WithEvents TxtHoraEntrada As TextBox
	Friend WithEvents TxtMatricula As TextBox
	Friend WithEvents CheckCoche As CheckBox
	Friend WithEvents CheckMoto As CheckBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents BtnAceptar As Button
	Friend WithEvents BtnCancelar As Button
End Class
