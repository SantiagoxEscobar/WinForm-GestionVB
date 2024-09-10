<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Me.pnlClientes = New System.Windows.Forms.Panel()
        Me.pnlDgv = New System.Windows.Forms.Panel()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.pnlFiltro = New System.Windows.Forms.Panel()
        Me.rbNombreClientes = New System.Windows.Forms.RadioButton()
        Me.rbTelefonoClientes = New System.Windows.Forms.RadioButton()
        Me.rbIdClientes = New System.Windows.Forms.RadioButton()
        Me.rbCorreoClientes = New System.Windows.Forms.RadioButton()
        Me.btnLimpiarClientes = New System.Windows.Forms.Button()
        Me.lblFiltroClientes = New System.Windows.Forms.Label()
        Me.pnlABM = New System.Windows.Forms.Panel()
        Me.btnEliminarClientes = New System.Windows.Forms.Button()
        Me.btnEditarClientes = New System.Windows.Forms.Button()
        Me.btnAgregarClientes = New System.Windows.Forms.Button()
        Me.PnlBuscar = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblOrdenarClientes = New System.Windows.Forms.Label()
        Me.cbxOrdenarClientes = New System.Windows.Forms.ComboBox()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.pnlClientes.SuspendLayout()
        Me.pnlDgv.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltro.SuspendLayout()
        Me.pnlABM.SuspendLayout()
        Me.PnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlClientes
        '
        Me.pnlClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlClientes.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlClientes.Controls.Add(Me.pnlDgv)
        Me.pnlClientes.Controls.Add(Me.pnlFiltro)
        Me.pnlClientes.Controls.Add(Me.pnlABM)
        Me.pnlClientes.Controls.Add(Me.PnlBuscar)
        Me.pnlClientes.Controls.Add(Me.lblClientes)
        Me.pnlClientes.Location = New System.Drawing.Point(168, 8)
        Me.pnlClientes.Name = "pnlClientes"
        Me.pnlClientes.Size = New System.Drawing.Size(640, 437)
        Me.pnlClientes.TabIndex = 4
        '
        'pnlDgv
        '
        Me.pnlDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDgv.Controls.Add(Me.dgvClientes)
        Me.pnlDgv.Location = New System.Drawing.Point(0, 110)
        Me.pnlDgv.Name = "pnlDgv"
        Me.pnlDgv.Size = New System.Drawing.Size(513, 257)
        Me.pnlDgv.TabIndex = 7
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(513, 257)
        Me.dgvClientes.StandardTab = True
        Me.dgvClientes.TabIndex = 0
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.rbNombreClientes)
        Me.pnlFiltro.Controls.Add(Me.rbTelefonoClientes)
        Me.pnlFiltro.Controls.Add(Me.rbIdClientes)
        Me.pnlFiltro.Controls.Add(Me.rbCorreoClientes)
        Me.pnlFiltro.Controls.Add(Me.btnLimpiarClientes)
        Me.pnlFiltro.Controls.Add(Me.lblFiltroClientes)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFiltro.Location = New System.Drawing.Point(519, 110)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(121, 277)
        Me.pnlFiltro.TabIndex = 6
        '
        'rbNombreClientes
        '
        Me.rbNombreClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbNombreClientes.AutoSize = True
        Me.rbNombreClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbNombreClientes.Location = New System.Drawing.Point(10, 120)
        Me.rbNombreClientes.Name = "rbNombreClientes"
        Me.rbNombreClientes.Size = New System.Drawing.Size(67, 20)
        Me.rbNombreClientes.TabIndex = 1
        Me.rbNombreClientes.TabStop = True
        Me.rbNombreClientes.Text = "Cliente"
        Me.rbNombreClientes.UseVisualStyleBackColor = True
        '
        'rbTelefonoClientes
        '
        Me.rbTelefonoClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTelefonoClientes.AutoSize = True
        Me.rbTelefonoClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTelefonoClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbTelefonoClientes.Location = New System.Drawing.Point(10, 150)
        Me.rbTelefonoClientes.Name = "rbTelefonoClientes"
        Me.rbTelefonoClientes.Size = New System.Drawing.Size(80, 20)
        Me.rbTelefonoClientes.TabIndex = 2
        Me.rbTelefonoClientes.TabStop = True
        Me.rbTelefonoClientes.Text = "Teléfono"
        Me.rbTelefonoClientes.UseVisualStyleBackColor = True
        '
        'rbIdClientes
        '
        Me.rbIdClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbIdClientes.AutoSize = True
        Me.rbIdClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIdClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbIdClientes.Location = New System.Drawing.Point(10, 90)
        Me.rbIdClientes.Name = "rbIdClientes"
        Me.rbIdClientes.Size = New System.Drawing.Size(39, 20)
        Me.rbIdClientes.TabIndex = 0
        Me.rbIdClientes.TabStop = True
        Me.rbIdClientes.Text = "ID"
        Me.rbIdClientes.UseVisualStyleBackColor = True
        '
        'rbCorreoClientes
        '
        Me.rbCorreoClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbCorreoClientes.AutoSize = True
        Me.rbCorreoClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCorreoClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbCorreoClientes.Location = New System.Drawing.Point(10, 180)
        Me.rbCorreoClientes.Name = "rbCorreoClientes"
        Me.rbCorreoClientes.Size = New System.Drawing.Size(67, 20)
        Me.rbCorreoClientes.TabIndex = 3
        Me.rbCorreoClientes.TabStop = True
        Me.rbCorreoClientes.Text = "Correo"
        Me.rbCorreoClientes.UseVisualStyleBackColor = True
        '
        'btnLimpiarClientes
        '
        Me.btnLimpiarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLimpiarClientes.FlatAppearance.BorderSize = 0
        Me.btnLimpiarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLimpiarClientes.Location = New System.Drawing.Point(10, 220)
        Me.btnLimpiarClientes.Name = "btnLimpiarClientes"
        Me.btnLimpiarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiarClientes.TabIndex = 4
        Me.btnLimpiarClientes.Text = "Limpiar"
        Me.btnLimpiarClientes.UseVisualStyleBackColor = False
        '
        'lblFiltroClientes
        '
        Me.lblFiltroClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiltroClientes.AutoSize = True
        Me.lblFiltroClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblFiltroClientes.Location = New System.Drawing.Point(10, 50)
        Me.lblFiltroClientes.Name = "lblFiltroClientes"
        Me.lblFiltroClientes.Size = New System.Drawing.Size(80, 20)
        Me.lblFiltroClientes.TabIndex = 4
        Me.lblFiltroClientes.Text = "Filtrar por:"
        '
        'pnlABM
        '
        Me.pnlABM.Controls.Add(Me.btnEliminarClientes)
        Me.pnlABM.Controls.Add(Me.btnEditarClientes)
        Me.pnlABM.Controls.Add(Me.btnAgregarClientes)
        Me.pnlABM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlABM.Location = New System.Drawing.Point(0, 387)
        Me.pnlABM.Name = "pnlABM"
        Me.pnlABM.Size = New System.Drawing.Size(640, 50)
        Me.pnlABM.TabIndex = 5
        '
        'btnEliminarClientes
        '
        Me.btnEliminarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnEliminarClientes.FlatAppearance.BorderSize = 0
        Me.btnEliminarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnEliminarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEliminarClientes.Location = New System.Drawing.Point(526, 10)
        Me.btnEliminarClientes.Name = "btnEliminarClientes"
        Me.btnEliminarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminarClientes.TabIndex = 2
        Me.btnEliminarClientes.Text = "Eliminar"
        Me.btnEliminarClientes.UseVisualStyleBackColor = False
        '
        'btnEditarClientes
        '
        Me.btnEditarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnEditarClientes.FlatAppearance.BorderSize = 0
        Me.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditarClientes.Location = New System.Drawing.Point(127, 10)
        Me.btnEditarClientes.Name = "btnEditarClientes"
        Me.btnEditarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnEditarClientes.TabIndex = 1
        Me.btnEditarClientes.Text = "Editar"
        Me.btnEditarClientes.UseVisualStyleBackColor = False
        '
        'btnAgregarClientes
        '
        Me.btnAgregarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarClientes.FlatAppearance.BorderSize = 0
        Me.btnAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAgregarClientes.Location = New System.Drawing.Point(10, 10)
        Me.btnAgregarClientes.Name = "btnAgregarClientes"
        Me.btnAgregarClientes.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarClientes.TabIndex = 0
        Me.btnAgregarClientes.Text = "Agregar"
        Me.btnAgregarClientes.UseVisualStyleBackColor = False
        '
        'PnlBuscar
        '
        Me.PnlBuscar.Controls.Add(Me.btnBuscar)
        Me.PnlBuscar.Controls.Add(Me.lblOrdenarClientes)
        Me.PnlBuscar.Controls.Add(Me.cbxOrdenarClientes)
        Me.PnlBuscar.Controls.Add(Me.txtBuscarClientes)
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
        'lblOrdenarClientes
        '
        Me.lblOrdenarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdenarClientes.AutoSize = True
        Me.lblOrdenarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenarClientes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOrdenarClientes.Location = New System.Drawing.Point(429, 16)
        Me.lblOrdenarClientes.Name = "lblOrdenarClientes"
        Me.lblOrdenarClientes.Size = New System.Drawing.Size(71, 20)
        Me.lblOrdenarClientes.TabIndex = 3
        Me.lblOrdenarClientes.Text = "Ordenar:"
        '
        'cbxOrdenarClientes
        '
        Me.cbxOrdenarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOrdenarClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOrdenarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrdenarClientes.FormattingEnabled = True
        Me.cbxOrdenarClientes.Location = New System.Drawing.Point(516, 13)
        Me.cbxOrdenarClientes.Name = "cbxOrdenarClientes"
        Me.cbxOrdenarClientes.Size = New System.Drawing.Size(121, 26)
        Me.cbxOrdenarClientes.TabIndex = 2
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(10, 13)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(300, 26)
        Me.txtBuscarClientes.TabIndex = 0
        '
        'lblClientes
        '
        Me.lblClientes.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblClientes.Location = New System.Drawing.Point(0, 0)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblClientes.Size = New System.Drawing.Size(640, 60)
        Me.lblClientes.TabIndex = 2
        Me.lblClientes.Text = "Clientes"
        Me.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.pnlClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmClientes"
        Me.pnlClientes.ResumeLayout(False)
        Me.pnlDgv.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlFiltro.PerformLayout()
        Me.pnlABM.ResumeLayout(False)
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlClientes As Panel
    Friend WithEvents lblClientes As Label
    Friend WithEvents PnlBuscar As Panel
    Friend WithEvents pnlABM As Panel
    Friend WithEvents btnEliminarClientes As Button
    Friend WithEvents btnEditarClientes As Button
    Friend WithEvents btnAgregarClientes As Button
    Friend WithEvents txtBuscarClientes As TextBox
    Friend WithEvents cbxOrdenarClientes As ComboBox
    Friend WithEvents lblOrdenarClientes As Label
    Friend WithEvents pnlFiltro As Panel
    Friend WithEvents rbTelefonoClientes As RadioButton
    Friend WithEvents rbIdClientes As RadioButton
    Friend WithEvents rbCorreoClientes As RadioButton
    Friend WithEvents btnLimpiarClientes As Button
    Friend WithEvents lblFiltroClientes As Label
    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents rbNombreClientes As RadioButton
End Class
