<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistancias
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
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.comUnidades = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMetros = New System.Windows.Forms.Label()
        Me.lblPulgadas = New System.Windows.Forms.Label()
        Me.lblPies = New System.Windows.Forms.Label()
        Me.lblYardas = New System.Windows.Forms.Label()
        Me.lblMillas = New System.Windows.Forms.Label()
        Me.txtPies = New System.Windows.Forms.TextBox()
        Me.txtPulgadas = New System.Windows.Forms.TextBox()
        Me.txtMetros = New System.Windows.Forms.TextBox()
        Me.txtYardas = New System.Windows.Forms.TextBox()
        Me.txtMillas = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(10, 32)
        Me.txtValor.MaxLength = 6
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(127, 32)
        Me.txtValor.TabIndex = 0
        Me.txtValor.Text = "0"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'comUnidades
        '
        Me.comUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comUnidades.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comUnidades.FormattingEnabled = True
        Me.comUnidades.Items.AddRange(New Object() {"Metros", "Pulgadas ", "Pies", "Yardas", "Millas"})
        Me.comUnidades.Location = New System.Drawing.Point(179, 30)
        Me.comUnidades.Name = "comUnidades"
        Me.comUnidades.Size = New System.Drawing.Size(140, 31)
        Me.comUnidades.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(364, 26)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(130, 43)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.comUnidades)
        Me.Panel1.Controls.Add(Me.txtValor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 96)
        Me.Panel1.TabIndex = 3
        '
        'lblMetros
        '
        Me.lblMetros.AutoSize = True
        Me.lblMetros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetros.Location = New System.Drawing.Point(133, 166)
        Me.lblMetros.Name = "lblMetros"
        Me.lblMetros.Size = New System.Drawing.Size(87, 23)
        Me.lblMetros.TabIndex = 4
        Me.lblMetros.Text = "Metros: "
        '
        'lblPulgadas
        '
        Me.lblPulgadas.AutoSize = True
        Me.lblPulgadas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulgadas.Location = New System.Drawing.Point(133, 229)
        Me.lblPulgadas.Name = "lblPulgadas"
        Me.lblPulgadas.Size = New System.Drawing.Size(111, 23)
        Me.lblPulgadas.TabIndex = 5
        Me.lblPulgadas.Text = "Pulgadas: "
        '
        'lblPies
        '
        Me.lblPies.AutoSize = True
        Me.lblPies.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPies.Location = New System.Drawing.Point(133, 290)
        Me.lblPies.Name = "lblPies"
        Me.lblPies.Size = New System.Drawing.Size(54, 23)
        Me.lblPies.TabIndex = 6
        Me.lblPies.Text = "Pies:"
        '
        'lblYardas
        '
        Me.lblYardas.AutoSize = True
        Me.lblYardas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYardas.Location = New System.Drawing.Point(133, 347)
        Me.lblYardas.Name = "lblYardas"
        Me.lblYardas.Size = New System.Drawing.Size(88, 23)
        Me.lblYardas.TabIndex = 7
        Me.lblYardas.Text = "Yardas: "
        '
        'lblMillas
        '
        Me.lblMillas.AutoSize = True
        Me.lblMillas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMillas.Location = New System.Drawing.Point(133, 409)
        Me.lblMillas.Name = "lblMillas"
        Me.lblMillas.Size = New System.Drawing.Size(71, 23)
        Me.lblMillas.TabIndex = 8
        Me.lblMillas.Text = "Millas:"
        '
        'txtPies
        '
        Me.txtPies.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPies.Location = New System.Drawing.Point(275, 281)
        Me.txtPies.Name = "txtPies"
        Me.txtPies.ReadOnly = True
        Me.txtPies.Size = New System.Drawing.Size(155, 32)
        Me.txtPies.TabIndex = 9
        Me.txtPies.Text = "0"
        Me.txtPies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPulgadas
        '
        Me.txtPulgadas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPulgadas.Location = New System.Drawing.Point(275, 220)
        Me.txtPulgadas.Name = "txtPulgadas"
        Me.txtPulgadas.ReadOnly = True
        Me.txtPulgadas.Size = New System.Drawing.Size(155, 32)
        Me.txtPulgadas.TabIndex = 10
        Me.txtPulgadas.Text = "0"
        Me.txtPulgadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMetros
        '
        Me.txtMetros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMetros.Location = New System.Drawing.Point(275, 157)
        Me.txtMetros.Name = "txtMetros"
        Me.txtMetros.ReadOnly = True
        Me.txtMetros.Size = New System.Drawing.Size(155, 32)
        Me.txtMetros.TabIndex = 11
        Me.txtMetros.Text = "0"
        Me.txtMetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYardas
        '
        Me.txtYardas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYardas.Location = New System.Drawing.Point(275, 338)
        Me.txtYardas.Name = "txtYardas"
        Me.txtYardas.ReadOnly = True
        Me.txtYardas.Size = New System.Drawing.Size(155, 32)
        Me.txtYardas.TabIndex = 12
        Me.txtYardas.Text = "0"
        Me.txtYardas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMillas
        '
        Me.txtMillas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMillas.Location = New System.Drawing.Point(275, 400)
        Me.txtMillas.Name = "txtMillas"
        Me.txtMillas.ReadOnly = True
        Me.txtMillas.Size = New System.Drawing.Size(155, 32)
        Me.txtMillas.TabIndex = 13
        Me.txtMillas.Text = "0"
        Me.txtMillas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmDistancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 488)
        Me.Controls.Add(Me.txtMillas)
        Me.Controls.Add(Me.txtYardas)
        Me.Controls.Add(Me.txtMetros)
        Me.Controls.Add(Me.txtPulgadas)
        Me.Controls.Add(Me.txtPies)
        Me.Controls.Add(Me.lblMillas)
        Me.Controls.Add(Me.lblYardas)
        Me.Controls.Add(Me.lblPies)
        Me.Controls.Add(Me.lblPulgadas)
        Me.Controls.Add(Me.lblMetros)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDistancias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distancias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValor As TextBox
    Friend WithEvents comUnidades As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMetros As Label
    Friend WithEvents lblPulgadas As Label
    Friend WithEvents lblPies As Label
    Friend WithEvents lblYardas As Label
    Friend WithEvents lblMillas As Label
    Friend WithEvents txtPies As TextBox
    Friend WithEvents txtPulgadas As TextBox
    Friend WithEvents txtMetros As TextBox
    Friend WithEvents txtYardas As TextBox
    Friend WithEvents txtMillas As TextBox
End Class
