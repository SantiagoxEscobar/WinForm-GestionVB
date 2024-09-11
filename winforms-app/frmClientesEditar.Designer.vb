<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesEditar
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
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnEditarClientes = New System.Windows.Forms.Button()
        Me.btnCancelarClientes = New System.Windows.Forms.Button()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCliente.Location = New System.Drawing.Point(31, 23)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(62, 20)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCorreo.Location = New System.Drawing.Point(31, 123)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreo.TabIndex = 1
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTelefono.Location = New System.Drawing.Point(31, 73)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 2
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(150, 20)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(250, 26)
        Me.txtCliente.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(150, 70)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(250, 26)
        Me.txtTelefono.TabIndex = 4
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(150, 120)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(250, 26)
        Me.txtCorreo.TabIndex = 5
        '
        'btnEditarClientes
        '
        Me.btnEditarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarClientes.FlatAppearance.BorderSize = 0
        Me.btnEditarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditarClientes.Location = New System.Drawing.Point(35, 190)
        Me.btnEditarClientes.Name = "btnEditarClientes"
        Me.btnEditarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnEditarClientes.TabIndex = 9
        Me.btnEditarClientes.Text = "Confirmar"
        Me.btnEditarClientes.UseVisualStyleBackColor = False
        '
        'btnCancelarClientes
        '
        Me.btnCancelarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnCancelarClientes.FlatAppearance.BorderSize = 0
        Me.btnCancelarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancelarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancelarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCancelarClientes.Location = New System.Drawing.Point(300, 190)
        Me.btnCancelarClientes.Name = "btnCancelarClientes"
        Me.btnCancelarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelarClientes.TabIndex = 10
        Me.btnCancelarClientes.Text = "Cancelar"
        Me.btnCancelarClientes.UseVisualStyleBackColor = False
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAdvertencia.Location = New System.Drawing.Point(35, 160)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(365, 16)
        Me.lblAdvertencia.TabIndex = 11
        Me.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = True
        Me.lblAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAsterisco.Location = New System.Drawing.Point(86, 18)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(20, 25)
        Me.lblAsterisco.TabIndex = 12
        Me.lblAsterisco.Text = "*"
        '
        'frmClientesEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 241)
        Me.Controls.Add(Me.lblAsterisco)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.btnCancelarClientes)
        Me.Controls.Add(Me.btnEditarClientes)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblCliente)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 280)
        Me.Name = "frmClientesEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCliente As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnEditarClientes As Button
    Friend WithEvents btnCancelarClientes As Button
    Friend WithEvents lblAdvertencia As Label
    Friend WithEvents lblAsterisco As Label
End Class
