<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sacar_Cuentas
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
		Me.BtnAceptar = New System.Windows.Forms.Button()
		Me.BtnCancelar = New System.Windows.Forms.Button()
		Me.LblGastos = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.BtnImprimir = New System.Windows.Forms.Button()
		Me.LblIngresos = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.CheckGastos = New System.Windows.Forms.CheckBox()
		Me.CheckIngresos = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(195, 35)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(349, 42)
		Me.Label1.TabIndex = 25
		Me.Label1.Text = "SACAR CUENTAS"
		'
		'BtnAceptar
		'
		Me.BtnAceptar.Location = New System.Drawing.Point(284, 280)
		Me.BtnAceptar.Name = "BtnAceptar"
		Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.BtnAceptar.TabIndex = 34
		Me.BtnAceptar.Text = "Aceptar"
		Me.BtnAceptar.UseVisualStyleBackColor = True
		'
		'BtnCancelar
		'
		Me.BtnCancelar.Location = New System.Drawing.Point(188, 280)
		Me.BtnCancelar.Name = "BtnCancelar"
		Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.BtnCancelar.TabIndex = 33
		Me.BtnCancelar.Text = "Cancelar"
		Me.BtnCancelar.UseVisualStyleBackColor = True
		'
		'LblGastos
		'
		Me.LblGastos.AutoSize = True
		Me.LblGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblGastos.Location = New System.Drawing.Point(321, 147)
		Me.LblGastos.Name = "LblGastos"
		Me.LblGastos.Size = New System.Drawing.Size(51, 25)
		Me.LblGastos.TabIndex = 32
		Me.LblGastos.Text = "12€"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(177, 147)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(119, 25)
		Me.Label5.TabIndex = 31
		Me.Label5.Text = "GASTOS: "
		'
		'BtnImprimir
		'
		Me.BtnImprimir.Location = New System.Drawing.Point(450, 97)
		Me.BtnImprimir.Name = "BtnImprimir"
		Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
		Me.BtnImprimir.TabIndex = 30
		Me.BtnImprimir.Text = "Imprimir"
		Me.BtnImprimir.UseVisualStyleBackColor = True
		'
		'LblIngresos
		'
		Me.LblIngresos.AutoSize = True
		Me.LblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblIngresos.Location = New System.Drawing.Point(321, 186)
		Me.LblIngresos.Name = "LblIngresos"
		Me.LblIngresos.Size = New System.Drawing.Size(38, 25)
		Me.LblIngresos.TabIndex = 36
		Me.LblIngresos.Text = "0€"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(177, 186)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(143, 25)
		Me.Label3.TabIndex = 35
		Me.Label3.Text = "INGRESOS: "
		'
		'CheckGastos
		'
		Me.CheckGastos.AutoSize = True
		Me.CheckGastos.Checked = True
		Me.CheckGastos.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckGastos.Location = New System.Drawing.Point(450, 147)
		Me.CheckGastos.Name = "CheckGastos"
		Me.CheckGastos.Size = New System.Drawing.Size(59, 17)
		Me.CheckGastos.TabIndex = 37
		Me.CheckGastos.Text = "Gastos"
		Me.CheckGastos.UseVisualStyleBackColor = True
		'
		'CheckIngresos
		'
		Me.CheckIngresos.AutoSize = True
		Me.CheckIngresos.Checked = True
		Me.CheckIngresos.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckIngresos.Location = New System.Drawing.Point(450, 194)
		Me.CheckIngresos.Name = "CheckIngresos"
		Me.CheckIngresos.Size = New System.Drawing.Size(66, 17)
		Me.CheckIngresos.TabIndex = 38
		Me.CheckIngresos.Text = "Ingresos"
		Me.CheckIngresos.UseVisualStyleBackColor = True
		'
		'Sacar_Cuentas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(745, 428)
		Me.Controls.Add(Me.CheckIngresos)
		Me.Controls.Add(Me.CheckGastos)
		Me.Controls.Add(Me.LblIngresos)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.BtnAceptar)
		Me.Controls.Add(Me.BtnCancelar)
		Me.Controls.Add(Me.LblGastos)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.BtnImprimir)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Sacar_Cuentas"
		Me.Text = "Sacar_Cuentas"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents BtnAceptar As Button
	Friend WithEvents BtnCancelar As Button
	Friend WithEvents LblGastos As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents BtnImprimir As Button
	Friend WithEvents LblIngresos As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents CheckGastos As CheckBox
	Friend WithEvents CheckIngresos As CheckBox
End Class
