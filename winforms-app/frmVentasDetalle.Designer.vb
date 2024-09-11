<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentasDetalle
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
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTotalVenta = New System.Windows.Forms.Label()
        Me.lblCorreoCliente = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lbltelefonoCliente = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.pnlDgv = New System.Windows.Forms.Panel()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.pnlABM = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnLimpiarDetalle = New System.Windows.Forms.Button()
        Me.btnElminarDetalle = New System.Windows.Forms.Button()
        Me.btnVolverDetalle = New System.Windows.Forms.Button()
        Me.PnlBuscar = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.pnlDetalle.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnlDgv.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlABM.SuspendLayout()
        Me.PnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetalle.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlDetalle.Controls.Add(Me.Panel2)
        Me.pnlDetalle.Controls.Add(Me.pnl1)
        Me.pnlDetalle.Controls.Add(Me.pnlDgv)
        Me.pnlDetalle.Controls.Add(Me.pnlABM)
        Me.pnlDetalle.Controls.Add(Me.PnlBuscar)
        Me.pnlDetalle.Location = New System.Drawing.Point(168, 8)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(640, 437)
        Me.pnlDetalle.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblCorreo)
        Me.Panel2.Controls.Add(Me.lblTotalVenta)
        Me.Panel2.Controls.Add(Me.lblCorreoCliente)
        Me.Panel2.Location = New System.Drawing.Point(0, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 37)
        Me.Panel2.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Location = New System.Drawing.Point(490, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 20)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "."
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorreo
        '
        Me.lblCorreo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCorreo.Location = New System.Drawing.Point(110, 10)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(260, 20)
        Me.lblCorreo.TabIndex = 29
        Me.lblCorreo.Text = "."
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalVenta
        '
        Me.lblTotalVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVenta.AutoSize = True
        Me.lblTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVenta.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalVenta.Location = New System.Drawing.Point(409, 10)
        Me.lblTotalVenta.Name = "lblTotalVenta"
        Me.lblTotalVenta.Size = New System.Drawing.Size(48, 20)
        Me.lblTotalVenta.TabIndex = 31
        Me.lblTotalVenta.Text = "Total:"
        Me.lblTotalVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorreoCliente
        '
        Me.lblCorreoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCorreoCliente.AutoSize = True
        Me.lblCorreoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCorreoCliente.Location = New System.Drawing.Point(6, 10)
        Me.lblCorreoCliente.Name = "lblCorreoCliente"
        Me.lblCorreoCliente.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreoCliente.TabIndex = 28
        Me.lblCorreoCliente.Text = "Correo:"
        Me.lblCorreoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.lblFecha)
        Me.pnl1.Controls.Add(Me.lblTelefono)
        Me.pnl1.Controls.Add(Me.lbltelefonoCliente)
        Me.pnl1.Controls.Add(Me.lblFechaVenta)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 60)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(640, 40)
        Me.pnl1.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(490, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFecha.Size = New System.Drawing.Size(150, 20)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "."
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTelefono.Location = New System.Drawing.Point(110, 10)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(260, 20)
        Me.lblTelefono.TabIndex = 30
        Me.lblTelefono.Text = "."
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltelefonoCliente
        '
        Me.lbltelefonoCliente.AutoSize = True
        Me.lbltelefonoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefonoCliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbltelefonoCliente.Location = New System.Drawing.Point(6, 10)
        Me.lbltelefonoCliente.Name = "lbltelefonoCliente"
        Me.lbltelefonoCliente.Size = New System.Drawing.Size(75, 20)
        Me.lbltelefonoCliente.TabIndex = 27
        Me.lbltelefonoCliente.Text = "Teléfono:"
        Me.lbltelefonoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaVenta.AutoSize = True
        Me.lblFechaVenta.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblFechaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFechaVenta.Location = New System.Drawing.Point(401, 10)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFechaVenta.Size = New System.Drawing.Size(68, 20)
        Me.lblFechaVenta.TabIndex = 5
        Me.lblFechaVenta.Text = "Fecha:"
        Me.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDgv
        '
        Me.pnlDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDgv.Controls.Add(Me.dgvDetalle)
        Me.pnlDgv.Location = New System.Drawing.Point(0, 98)
        Me.pnlDgv.Name = "pnlDgv"
        Me.pnlDgv.Size = New System.Drawing.Size(640, 240)
        Me.pnlDgv.TabIndex = 7
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetalle.Location = New System.Drawing.Point(0, 0)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(640, 240)
        Me.dgvDetalle.StandardTab = True
        Me.dgvDetalle.TabIndex = 0
        '
        'pnlABM
        '
        Me.pnlABM.Controls.Add(Me.btnEditar)
        Me.pnlABM.Controls.Add(Me.btnLimpiarDetalle)
        Me.pnlABM.Controls.Add(Me.btnElminarDetalle)
        Me.pnlABM.Controls.Add(Me.btnVolverDetalle)
        Me.pnlABM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlABM.Location = New System.Drawing.Point(0, 387)
        Me.pnlABM.Name = "pnlABM"
        Me.pnlABM.Size = New System.Drawing.Size(640, 50)
        Me.pnlABM.TabIndex = 5
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditar.Location = New System.Drawing.Point(126, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnLimpiarDetalle
        '
        Me.btnLimpiarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiarDetalle.FlatAppearance.BorderSize = 0
        Me.btnLimpiarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLimpiarDetalle.Location = New System.Drawing.Point(413, 10)
        Me.btnLimpiarDetalle.Name = "btnLimpiarDetalle"
        Me.btnLimpiarDetalle.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiarDetalle.TabIndex = 4
        Me.btnLimpiarDetalle.Text = "Generar"
        Me.btnLimpiarDetalle.UseVisualStyleBackColor = False
        '
        'btnElminarDetalle
        '
        Me.btnElminarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnElminarDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnElminarDetalle.FlatAppearance.BorderSize = 0
        Me.btnElminarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnElminarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnElminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElminarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElminarDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnElminarDetalle.Location = New System.Drawing.Point(10, 10)
        Me.btnElminarDetalle.Name = "btnElminarDetalle"
        Me.btnElminarDetalle.Size = New System.Drawing.Size(100, 30)
        Me.btnElminarDetalle.TabIndex = 1
        Me.btnElminarDetalle.Text = "Eliminar"
        Me.btnElminarDetalle.UseVisualStyleBackColor = False
        '
        'btnVolverDetalle
        '
        Me.btnVolverDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolverDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnVolverDetalle.FlatAppearance.BorderSize = 0
        Me.btnVolverDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnVolverDetalle.Location = New System.Drawing.Point(529, 10)
        Me.btnVolverDetalle.Name = "btnVolverDetalle"
        Me.btnVolverDetalle.Size = New System.Drawing.Size(100, 30)
        Me.btnVolverDetalle.TabIndex = 0
        Me.btnVolverDetalle.Text = "Volver"
        Me.btnVolverDetalle.UseVisualStyleBackColor = False
        '
        'PnlBuscar
        '
        Me.PnlBuscar.Controls.Add(Me.lblNombre)
        Me.PnlBuscar.Controls.Add(Me.lblCliente)
        Me.PnlBuscar.Controls.Add(Me.lblVenta)
        Me.PnlBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBuscar.Location = New System.Drawing.Point(0, 0)
        Me.PnlBuscar.Name = "PnlBuscar"
        Me.PnlBuscar.Size = New System.Drawing.Size(640, 60)
        Me.PnlBuscar.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(490, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblNombre.Size = New System.Drawing.Size(150, 20)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "."
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(401, 28)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblCliente.Size = New System.Drawing.Size(72, 20)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVenta
        '
        Me.lblVenta.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblVenta.Location = New System.Drawing.Point(0, 0)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblVenta.Size = New System.Drawing.Size(370, 60)
        Me.lblVenta.TabIndex = 3
        Me.lblVenta.Text = "Venta N° "
        Me.lblVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVentasDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.pnlDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentasDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmClientes"
        Me.pnlDetalle.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnlDgv.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlABM.ResumeLayout(False)
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDetalle As Panel
    Friend WithEvents PnlBuscar As Panel
    Friend WithEvents pnlABM As Panel
    Friend WithEvents btnVolverDetalle As Button
    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents btnLimpiarDetalle As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblCorreoCliente As Label
    Friend WithEvents lbltelefonoCliente As Label
    Friend WithEvents lblVenta As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalVenta As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents btnElminarDetalle As Button
    Friend WithEvents btnEditar As Button
End Class
