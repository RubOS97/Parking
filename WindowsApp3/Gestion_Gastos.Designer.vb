<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Gastos
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
		Me.TxtConcepto = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtFecha = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtNumFactura = New System.Windows.Forms.TextBox()
		Me.TxtPrecio = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.BtnAceptar = New System.Windows.Forms.Button()
		Me.BtnCancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(200, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(365, 42)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "GESTION GASTOS"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(204, 131)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(53, 13)
		Me.Label4.TabIndex = 26
		Me.Label4.Text = "Concepto"
		'
		'TxtConcepto
		'
		Me.TxtConcepto.Location = New System.Drawing.Point(207, 147)
		Me.TxtConcepto.Name = "TxtConcepto"
		Me.TxtConcepto.Size = New System.Drawing.Size(345, 20)
		Me.TxtConcepto.TabIndex = 25
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(204, 183)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 28
		Me.Label2.Text = "Fecha"
		'
		'TxtFecha
		'
		Me.TxtFecha.Location = New System.Drawing.Point(207, 199)
		Me.TxtFecha.Name = "TxtFecha"
		Me.TxtFecha.Size = New System.Drawing.Size(345, 20)
		Me.TxtFecha.TabIndex = 27
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(204, 234)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(61, 13)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Nº  Factura"
		'
		'TxtNumFactura
		'
		Me.TxtNumFactura.Location = New System.Drawing.Point(207, 250)
		Me.TxtNumFactura.Name = "TxtNumFactura"
		Me.TxtNumFactura.Size = New System.Drawing.Size(345, 20)
		Me.TxtNumFactura.TabIndex = 29
		'
		'TxtPrecio
		'
		Me.TxtPrecio.Location = New System.Drawing.Point(207, 306)
		Me.TxtPrecio.Name = "TxtPrecio"
		Me.TxtPrecio.Size = New System.Drawing.Size(345, 20)
		Me.TxtPrecio.TabIndex = 31
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(204, 290)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(37, 13)
		Me.Label7.TabIndex = 32
		Me.Label7.Text = "Precio"
		'
		'BtnAceptar
		'
		Me.BtnAceptar.Location = New System.Drawing.Point(324, 368)
		Me.BtnAceptar.Name = "BtnAceptar"
		Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.BtnAceptar.TabIndex = 36
		Me.BtnAceptar.Text = "Aceptar"
		Me.BtnAceptar.UseVisualStyleBackColor = True
		'
		'BtnCancelar
		'
		Me.BtnCancelar.Location = New System.Drawing.Point(207, 368)
		Me.BtnCancelar.Name = "BtnCancelar"
		Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.BtnCancelar.TabIndex = 35
		Me.BtnCancelar.Text = "Cancelar"
		Me.BtnCancelar.UseVisualStyleBackColor = True
		'
		'Gestion_Gastos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.BtnAceptar)
		Me.Controls.Add(Me.BtnCancelar)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TxtPrecio)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TxtNumFactura)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtFecha)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TxtConcepto)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Gestion_Gastos"
		Me.Text = "Gestion_Gastos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TxtConcepto As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtFecha As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TxtNumFactura As TextBox
	Friend WithEvents TxtPrecio As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents BtnAceptar As Button
	Friend WithEvents BtnCancelar As Button
End Class
