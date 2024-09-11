<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentasEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEditarVentas = New System.Windows.Forms.Button()
        Me.btnCancelarVentas = New System.Windows.Forms.Button()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarListaProducto = New System.Windows.Forms.Button()
        Me.btnAgregarListaProducto = New System.Windows.Forms.Button()
        Me.lblDatosVenta = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblDatosCliente = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditarVentas
        '
        Me.btnEditarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarVentas.FlatAppearance.BorderSize = 0
        Me.btnEditarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditarVentas.Location = New System.Drawing.Point(469, 410)
        Me.btnEditarVentas.Name = "btnEditarVentas"
        Me.btnEditarVentas.Size = New System.Drawing.Size(100, 30)
        Me.btnEditarVentas.TabIndex = 9
        Me.btnEditarVentas.Text = "Confirmar"
        Me.btnEditarVentas.UseVisualStyleBackColor = False
        '
        'btnCancelarVentas
        '
        Me.btnCancelarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnCancelarVentas.FlatAppearance.BorderSize = 0
        Me.btnCancelarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancelarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancelarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCancelarVentas.Location = New System.Drawing.Point(690, 410)
        Me.btnCancelarVentas.Name = "btnCancelarVentas"
        Me.btnCancelarVentas.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelarVentas.TabIndex = 10
        Me.btnCancelarVentas.Text = "Cancelar"
        Me.btnCancelarVentas.UseVisualStyleBackColor = False
        '
        'lblProductos
        '
        Me.lblProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblProductos.Location = New System.Drawing.Point(26, 30)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(163, 24)
        Me.lblProductos.TabIndex = 27
        Me.lblProductos.Text = "Lista de productos"
        Me.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvProductos
        '
        Me.dgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.Location = New System.Drawing.Point(30, 66)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(410, 319)
        Me.dgvProductos.TabIndex = 28
        '
        'btnEliminarListaProducto
        '
        Me.btnEliminarListaProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarListaProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnEliminarListaProducto.FlatAppearance.BorderSize = 0
        Me.btnEliminarListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarListaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarListaProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEliminarListaProducto.Location = New System.Drawing.Point(150, 410)
        Me.btnEliminarListaProducto.Name = "btnEliminarListaProducto"
        Me.btnEliminarListaProducto.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminarListaProducto.TabIndex = 31
        Me.btnEliminarListaProducto.Text = "Eliminar"
        Me.btnEliminarListaProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarListaProducto
        '
        Me.btnAgregarListaProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarListaProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAgregarListaProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarListaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarListaProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAgregarListaProducto.Location = New System.Drawing.Point(30, 410)
        Me.btnAgregarListaProducto.Name = "btnAgregarListaProducto"
        Me.btnAgregarListaProducto.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarListaProducto.TabIndex = 34
        Me.btnAgregarListaProducto.Text = "Agregar"
        Me.btnAgregarListaProducto.UseVisualStyleBackColor = False
        '
        'lblDatosVenta
        '
        Me.lblDatosVenta.AutoSize = True
        Me.lblDatosVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosVenta.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDatosVenta.Location = New System.Drawing.Point(465, 30)
        Me.lblDatosVenta.Name = "lblDatosVenta"
        Me.lblDatosVenta.Size = New System.Drawing.Size(157, 24)
        Me.lblDatosVenta.TabIndex = 51
        Me.lblDatosVenta.Text = "Datos de la Venta"
        Me.lblDatosVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(590, 164)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(200, 26)
        Me.txtTotal.TabIndex = 50
        Me.txtTotal.Text = "0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Location = New System.Drawing.Point(465, 167)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 49
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(590, 111)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 26)
        Me.dtpFecha.TabIndex = 48
        Me.dtpFecha.Value = New Date(2024, 9, 10, 17, 48, 19, 0)
        '
        'lblDatosCliente
        '
        Me.lblDatosCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDatosCliente.AutoSize = True
        Me.lblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDatosCliente.Location = New System.Drawing.Point(465, 238)
        Me.lblDatosCliente.Name = "lblDatosCliente"
        Me.lblDatosCliente.Size = New System.Drawing.Size(151, 24)
        Me.lblDatosCliente.TabIndex = 47
        Me.lblDatosCliente.Text = "Datos del Cliente"
        Me.lblDatosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(590, 358)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(200, 22)
        Me.txtCorreo.TabIndex = 46
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(590, 318)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(200, 22)
        Me.txtTelefono.TabIndex = 45
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(590, 278)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(200, 22)
        Me.txtCliente.TabIndex = 44
        '
        'lblTelefono
        '
        Me.lblTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTelefono.Location = New System.Drawing.Point(466, 321)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(65, 16)
        Me.lblTelefono.TabIndex = 43
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCorreo.Location = New System.Drawing.Point(466, 361)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(52, 16)
        Me.lblCorreo.TabIndex = 42
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCliente.Location = New System.Drawing.Point(466, 281)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 16)
        Me.lblCliente.TabIndex = 41
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = True
        Me.lblAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAsterisco.Location = New System.Drawing.Point(546, 61)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(20, 25)
        Me.lblAsterisco.TabIndex = 40
        Me.lblAsterisco.Text = "*"
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAdvertencia.Location = New System.Drawing.Point(472, 210)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(321, 16)
        Me.lblAdvertencia.TabIndex = 39
        Me.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(590, 63)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(200, 26)
        Me.txtIdCliente.TabIndex = 38
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblFecha.Location = New System.Drawing.Point(465, 116)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 20)
        Me.lblFecha.TabIndex = 37
        Me.lblFecha.Text = "Fecha:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblIdCliente.Location = New System.Drawing.Point(465, 66)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(79, 20)
        Me.lblIdCliente.TabIndex = 36
        Me.lblIdCliente.Text = "IDCliente:"
        Me.lblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVentasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 461)
        Me.Controls.Add(Me.lblDatosVenta)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblDatosCliente)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblAsterisco)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.btnAgregarListaProducto)
        Me.Controls.Add(Me.btnEliminarListaProducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.btnCancelarVentas)
        Me.Controls.Add(Me.btnEditarVentas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(840, 500)
        Me.Name = "frmVentasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Venta"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditarVentas As Button
    Friend WithEvents btnCancelarVentas As Button
    Friend WithEvents lblProductos As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnEliminarListaProducto As Button
    Friend WithEvents btnAgregarListaProducto As Button
    Friend WithEvents lblDatosVenta As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblDatosCliente As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblAsterisco As Label
    Friend WithEvents lblAdvertencia As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblIdCliente As Label
End Class
