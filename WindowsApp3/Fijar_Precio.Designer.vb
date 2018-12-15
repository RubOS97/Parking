<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fijar_Precio
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
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TxtFecha = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.CheckMoto = New System.Windows.Forms.CheckBox()
		Me.CheckCoche = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtPrecio = New System.Windows.Forms.TextBox()
		Me.BtnCancelar = New System.Windows.Forms.Button()
		Me.BtnAceptar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(222, 123)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(37, 13)
		Me.Label4.TabIndex = 19
		Me.Label4.Text = "Fecha"
		'
		'TxtFecha
		'
		Me.TxtFecha.Location = New System.Drawing.Point(225, 139)
		Me.TxtFecha.Name = "TxtFecha"
		Me.TxtFecha.Size = New System.Drawing.Size(345, 20)
		Me.TxtFecha.TabIndex = 18
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(222, 243)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(89, 13)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "Tipo de Vehículo"
		'
		'CheckMoto
		'
		Me.CheckMoto.AutoSize = True
		Me.CheckMoto.Location = New System.Drawing.Point(342, 272)
		Me.CheckMoto.Name = "CheckMoto"
		Me.CheckMoto.Size = New System.Drawing.Size(50, 17)
		Me.CheckMoto.TabIndex = 21
		Me.CheckMoto.Text = "Moto"
		Me.CheckMoto.UseVisualStyleBackColor = True
		'
		'CheckCoche
		'
		Me.CheckCoche.AutoSize = True
		Me.CheckCoche.Location = New System.Drawing.Point(225, 272)
		Me.CheckCoche.Name = "CheckCoche"
		Me.CheckCoche.Size = New System.Drawing.Size(57, 17)
		Me.CheckCoche.TabIndex = 20
		Me.CheckCoche.Text = "Coche"
		Me.CheckCoche.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(243, 33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(311, 42)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "FIJAR PRECIOS"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(222, 178)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 25
		Me.Label2.Text = "Precio"
		'
		'TxtPrecio
		'
		Me.TxtPrecio.Location = New System.Drawing.Point(225, 194)
		Me.TxtPrecio.Name = "TxtPrecio"
		Me.TxtPrecio.Size = New System.Drawing.Size(345, 20)
		Me.TxtPrecio.TabIndex = 24
		'
		'BtnCancelar
		'
		Me.BtnCancelar.Location = New System.Drawing.Point(225, 327)
		Me.BtnCancelar.Name = "BtnCancelar"
		Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.BtnCancelar.TabIndex = 26
		Me.BtnCancelar.Text = "Cancelar"
		Me.BtnCancelar.UseVisualStyleBackColor = True
		'
		'BtnAceptar
		'
		Me.BtnAceptar.Location = New System.Drawing.Point(342, 327)
		Me.BtnAceptar.Name = "BtnAceptar"
		Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.BtnAceptar.TabIndex = 27
		Me.BtnAceptar.Text = "Aceptar"
		Me.BtnAceptar.UseVisualStyleBackColor = True
		'
		'Fijar_Precio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.BtnAceptar)
		Me.Controls.Add(Me.BtnCancelar)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtPrecio)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.CheckMoto)
		Me.Controls.Add(Me.CheckCoche)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TxtFecha)
		Me.Name = "Fijar_Precio"
		Me.Text = "Fijar_Precio"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label4 As Label
	Friend WithEvents TxtFecha As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents CheckMoto As CheckBox
	Friend WithEvents CheckCoche As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtPrecio As TextBox
	Friend WithEvents BtnCancelar As Button
	Friend WithEvents BtnAceptar As Button
End Class
