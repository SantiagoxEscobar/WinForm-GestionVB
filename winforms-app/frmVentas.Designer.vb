<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Me.pnlVentas = New System.Windows.Forms.Panel()
        Me.pnlDgv = New System.Windows.Forms.Panel()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.pnlFiltro = New System.Windows.Forms.Panel()
        Me.rbClienteVentas = New System.Windows.Forms.RadioButton()
        Me.rbFechaVentas = New System.Windows.Forms.RadioButton()
        Me.rbIdVentas = New System.Windows.Forms.RadioButton()
        Me.rbTotalVentas = New System.Windows.Forms.RadioButton()
        Me.btnLimpiarVentas = New System.Windows.Forms.Button()
        Me.lblFiltroVentas = New System.Windows.Forms.Label()
        Me.pnlABM = New System.Windows.Forms.Panel()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnDetalleVentas = New System.Windows.Forms.Button()
        Me.btnAgregarVentas = New System.Windows.Forms.Button()
        Me.PnlBuscar = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblOrdenarVentas = New System.Windows.Forms.Label()
        Me.cbxOrdenarVentas = New System.Windows.Forms.ComboBox()
        Me.txtBuscarVentas = New System.Windows.Forms.TextBox()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.pnlVentas.SuspendLayout()
        Me.pnlDgv.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltro.SuspendLayout()
        Me.pnlABM.SuspendLayout()
        Me.PnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlVentas
        '
        Me.pnlVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlVentas.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlVentas.Controls.Add(Me.pnlDgv)
        Me.pnlVentas.Controls.Add(Me.pnlFiltro)
        Me.pnlVentas.Controls.Add(Me.pnlABM)
        Me.pnlVentas.Controls.Add(Me.PnlBuscar)
        Me.pnlVentas.Controls.Add(Me.lblVentas)
        Me.pnlVentas.Location = New System.Drawing.Point(168, 8)
        Me.pnlVentas.Name = "pnlVentas"
        Me.pnlVentas.Size = New System.Drawing.Size(640, 437)
        Me.pnlVentas.TabIndex = 4
        '
        'pnlDgv
        '
        Me.pnlDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDgv.Controls.Add(Me.dgvVentas)
        Me.pnlDgv.Location = New System.Drawing.Point(0, 110)
        Me.pnlDgv.Name = "pnlDgv"
        Me.pnlDgv.Size = New System.Drawing.Size(513, 257)
        Me.pnlDgv.TabIndex = 7
        '
        'dgvVentas
        '
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.Location = New System.Drawing.Point(0, 0)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(513, 257)
        Me.dgvVentas.StandardTab = True
        Me.dgvVentas.TabIndex = 0
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.rbClienteVentas)
        Me.pnlFiltro.Controls.Add(Me.rbFechaVentas)
        Me.pnlFiltro.Controls.Add(Me.rbIdVentas)
        Me.pnlFiltro.Controls.Add(Me.rbTotalVentas)
        Me.pnlFiltro.Controls.Add(Me.btnLimpiarVentas)
        Me.pnlFiltro.Controls.Add(Me.lblFiltroVentas)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFiltro.Location = New System.Drawing.Point(519, 110)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(121, 277)
        Me.pnlFiltro.TabIndex = 6
        '
        'rbClienteVentas
        '
        Me.rbClienteVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbClienteVentas.AutoSize = True
        Me.rbClienteVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClienteVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbClienteVentas.Location = New System.Drawing.Point(10, 120)
        Me.rbClienteVentas.Name = "rbClienteVentas"
        Me.rbClienteVentas.Size = New System.Drawing.Size(67, 20)
        Me.rbClienteVentas.TabIndex = 1
        Me.rbClienteVentas.TabStop = True
        Me.rbClienteVentas.Text = "Cliente"
        Me.rbClienteVentas.UseVisualStyleBackColor = True
        '
        'rbFechaVentas
        '
        Me.rbFechaVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFechaVentas.AutoSize = True
        Me.rbFechaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFechaVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbFechaVentas.Location = New System.Drawing.Point(10, 150)
        Me.rbFechaVentas.Name = "rbFechaVentas"
        Me.rbFechaVentas.Size = New System.Drawing.Size(64, 20)
        Me.rbFechaVentas.TabIndex = 2
        Me.rbFechaVentas.TabStop = True
        Me.rbFechaVentas.Text = "Fecha"
        Me.rbFechaVentas.UseVisualStyleBackColor = True
        '
        'rbIdVentas
        '
        Me.rbIdVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbIdVentas.AutoSize = True
        Me.rbIdVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIdVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbIdVentas.Location = New System.Drawing.Point(10, 90)
        Me.rbIdVentas.Name = "rbIdVentas"
        Me.rbIdVentas.Size = New System.Drawing.Size(39, 20)
        Me.rbIdVentas.TabIndex = 0
        Me.rbIdVentas.TabStop = True
        Me.rbIdVentas.Text = "ID"
        Me.rbIdVentas.UseVisualStyleBackColor = True
        '
        'rbTotalVentas
        '
        Me.rbTotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTotalVentas.AutoSize = True
        Me.rbTotalVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTotalVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbTotalVentas.Location = New System.Drawing.Point(10, 180)
        Me.rbTotalVentas.Name = "rbTotalVentas"
        Me.rbTotalVentas.Size = New System.Drawing.Size(57, 20)
        Me.rbTotalVentas.TabIndex = 3
        Me.rbTotalVentas.TabStop = True
        Me.rbTotalVentas.Text = "Total"
        Me.rbTotalVentas.UseVisualStyleBackColor = True
        '
        'btnLimpiarVentas
        '
        Me.btnLimpiarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLimpiarVentas.FlatAppearance.BorderSize = 0
        Me.btnLimpiarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLimpiarVentas.Location = New System.Drawing.Point(10, 220)
        Me.btnLimpiarVentas.Name = "btnLimpiarVentas"
        Me.btnLimpiarVentas.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiarVentas.TabIndex = 4
        Me.btnLimpiarVentas.Text = "Limpiar"
        Me.btnLimpiarVentas.UseVisualStyleBackColor = False
        '
        'lblFiltroVentas
        '
        Me.lblFiltroVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiltroVentas.AutoSize = True
        Me.lblFiltroVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblFiltroVentas.Location = New System.Drawing.Point(10, 50)
        Me.lblFiltroVentas.Name = "lblFiltroVentas"
        Me.lblFiltroVentas.Size = New System.Drawing.Size(80, 20)
        Me.lblFiltroVentas.TabIndex = 4
        Me.lblFiltroVentas.Text = "Filtrar por:"
        '
        'pnlABM
        '
        Me.pnlABM.Controls.Add(Me.btnGenerar)
        Me.pnlABM.Controls.Add(Me.btnDetalleVentas)
        Me.pnlABM.Controls.Add(Me.btnAgregarVentas)
        Me.pnlABM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlABM.Location = New System.Drawing.Point(0, 387)
        Me.pnlABM.Name = "pnlABM"
        Me.pnlABM.Size = New System.Drawing.Size(640, 50)
        Me.pnlABM.TabIndex = 5
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerar.FlatAppearance.BorderSize = 0
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGenerar.Location = New System.Drawing.Point(413, 10)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 30)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnDetalleVentas
        '
        Me.btnDetalleVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetalleVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDetalleVentas.FlatAppearance.BorderSize = 0
        Me.btnDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDetalleVentas.Location = New System.Drawing.Point(529, 10)
        Me.btnDetalleVentas.Name = "btnDetalleVentas"
        Me.btnDetalleVentas.Size = New System.Drawing.Size(100, 30)
        Me.btnDetalleVentas.TabIndex = 1
        Me.btnDetalleVentas.Text = "Detalles"
        Me.btnDetalleVentas.UseVisualStyleBackColor = False
        '
        'btnAgregarVentas
        '
        Me.btnAgregarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarVentas.FlatAppearance.BorderSize = 0
        Me.btnAgregarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAgregarVentas.Location = New System.Drawing.Point(10, 10)
        Me.btnAgregarVentas.Name = "btnAgregarVentas"
        Me.btnAgregarVentas.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarVentas.TabIndex = 0
        Me.btnAgregarVentas.Text = "Agregar"
        Me.btnAgregarVentas.UseVisualStyleBackColor = False
        '
        'PnlBuscar
        '
        Me.PnlBuscar.Controls.Add(Me.btnBuscar)
        Me.PnlBuscar.Controls.Add(Me.lblOrdenarVentas)
        Me.PnlBuscar.Controls.Add(Me.cbxOrdenarVentas)
        Me.PnlBuscar.Controls.Add(Me.txtBuscarVentas)
        Me.PnlBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBuscar.Location = New System.Drawing.Point(0, 60)
        Me.PnlBuscar.Name = "PnlBuscar"
        Me.PnlBuscar.Size = New System.Drawing.Size(640, 50)
        Me.PnlBuscar.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(320, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 26)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblOrdenarVentas
        '
        Me.lblOrdenarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdenarVentas.AutoSize = True
        Me.lblOrdenarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenarVentas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOrdenarVentas.Location = New System.Drawing.Point(429, 16)
        Me.lblOrdenarVentas.Name = "lblOrdenarVentas"
        Me.lblOrdenarVentas.Size = New System.Drawing.Size(71, 20)
        Me.lblOrdenarVentas.TabIndex = 3
        Me.lblOrdenarVentas.Text = "Ordenar:"
        '
        'cbxOrdenarVentas
        '
        Me.cbxOrdenarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOrdenarVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOrdenarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrdenarVentas.FormattingEnabled = True
        Me.cbxOrdenarVentas.Location = New System.Drawing.Point(516, 13)
        Me.cbxOrdenarVentas.Name = "cbxOrdenarVentas"
        Me.cbxOrdenarVentas.Size = New System.Drawing.Size(121, 26)
        Me.cbxOrdenarVentas.TabIndex = 2
        '
        'txtBuscarVentas
        '
        Me.txtBuscarVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarVentas.Location = New System.Drawing.Point(10, 13)
        Me.txtBuscarVentas.Name = "txtBuscarVentas"
        Me.txtBuscarVentas.Size = New System.Drawing.Size(300, 26)
        Me.txtBuscarVentas.TabIndex = 0
        '
        'lblVentas
        '
        Me.lblVentas.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblVentas.Location = New System.Drawing.Point(0, 0)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblVentas.Size = New System.Drawing.Size(640, 60)
        Me.lblVentas.TabIndex = 2
        Me.lblVentas.Text = "Ventas"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.pnlVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmClientes"
        Me.pnlVentas.ResumeLayout(False)
        Me.pnlDgv.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlFiltro.PerformLayout()
        Me.pnlABM.ResumeLayout(False)
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlVentas As Panel
    Friend WithEvents lblVentas As Label
    Friend WithEvents PnlBuscar As Panel
    Friend WithEvents pnlABM As Panel
    Friend WithEvents btnDetalleVentas As Button
    Friend WithEvents btnAgregarVentas As Button
    Friend WithEvents txtBuscarVentas As TextBox
    Friend WithEvents cbxOrdenarVentas As ComboBox
    Friend WithEvents lblOrdenarVentas As Label
    Friend WithEvents pnlFiltro As Panel
    Friend WithEvents rbFechaVentas As RadioButton
    Friend WithEvents rbIdVentas As RadioButton
    Friend WithEvents rbTotalVentas As RadioButton
    Friend WithEvents btnLimpiarVentas As Button
    Friend WithEvents lblFiltroVentas As Label
    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents rbClienteVentas As RadioButton
    Friend WithEvents btnGenerar As Button
End Class
