<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Me.pnlProductos = New System.Windows.Forms.Panel()
        Me.pnlDgv = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlFiltro = New System.Windows.Forms.Panel()
        Me.rbNombreProductos = New System.Windows.Forms.RadioButton()
        Me.rbPrecioProductos = New System.Windows.Forms.RadioButton()
        Me.rbIdProductos = New System.Windows.Forms.RadioButton()
        Me.rbCategoriaProductos = New System.Windows.Forms.RadioButton()
        Me.btnLimpiarProductos = New System.Windows.Forms.Button()
        Me.lblFiltroProductos = New System.Windows.Forms.Label()
        Me.pnlABM = New System.Windows.Forms.Panel()
        Me.btnEliminarProductos = New System.Windows.Forms.Button()
        Me.btnEditarProductos = New System.Windows.Forms.Button()
        Me.btnAgregarProductos = New System.Windows.Forms.Button()
        Me.PnlBuscar = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblOrdenarProductos = New System.Windows.Forms.Label()
        Me.cbxOrdenarProductos = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.pnlProductos.SuspendLayout()
        Me.pnlDgv.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltro.SuspendLayout()
        Me.pnlABM.SuspendLayout()
        Me.PnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProductos
        '
        Me.pnlProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlProductos.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlProductos.Controls.Add(Me.pnlDgv)
        Me.pnlProductos.Controls.Add(Me.pnlFiltro)
        Me.pnlProductos.Controls.Add(Me.pnlABM)
        Me.pnlProductos.Controls.Add(Me.PnlBuscar)
        Me.pnlProductos.Controls.Add(Me.lblProductos)
        Me.pnlProductos.Location = New System.Drawing.Point(168, 8)
        Me.pnlProductos.Name = "pnlProductos"
        Me.pnlProductos.Size = New System.Drawing.Size(640, 437)
        Me.pnlProductos.TabIndex = 4
        '
        'pnlDgv
        '
        Me.pnlDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDgv.Controls.Add(Me.dgvProductos)
        Me.pnlDgv.Location = New System.Drawing.Point(0, 110)
        Me.pnlDgv.Name = "pnlDgv"
        Me.pnlDgv.Size = New System.Drawing.Size(513, 257)
        Me.pnlDgv.TabIndex = 7
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(513, 257)
        Me.dgvProductos.StandardTab = True
        Me.dgvProductos.TabIndex = 0
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.rbNombreProductos)
        Me.pnlFiltro.Controls.Add(Me.rbPrecioProductos)
        Me.pnlFiltro.Controls.Add(Me.rbIdProductos)
        Me.pnlFiltro.Controls.Add(Me.rbCategoriaProductos)
        Me.pnlFiltro.Controls.Add(Me.btnLimpiarProductos)
        Me.pnlFiltro.Controls.Add(Me.lblFiltroProductos)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFiltro.Location = New System.Drawing.Point(519, 110)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(121, 277)
        Me.pnlFiltro.TabIndex = 6
        '
        'rbNombreProductos
        '
        Me.rbNombreProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbNombreProductos.AutoSize = True
        Me.rbNombreProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbNombreProductos.Location = New System.Drawing.Point(10, 120)
        Me.rbNombreProductos.Name = "rbNombreProductos"
        Me.rbNombreProductos.Size = New System.Drawing.Size(80, 20)
        Me.rbNombreProductos.TabIndex = 1
        Me.rbNombreProductos.TabStop = True
        Me.rbNombreProductos.Text = "Producto"
        Me.rbNombreProductos.UseVisualStyleBackColor = True
        '
        'rbPrecioProductos
        '
        Me.rbPrecioProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbPrecioProductos.AutoSize = True
        Me.rbPrecioProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrecioProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbPrecioProductos.Location = New System.Drawing.Point(10, 150)
        Me.rbPrecioProductos.Name = "rbPrecioProductos"
        Me.rbPrecioProductos.Size = New System.Drawing.Size(65, 20)
        Me.rbPrecioProductos.TabIndex = 2
        Me.rbPrecioProductos.TabStop = True
        Me.rbPrecioProductos.Text = "Precio"
        Me.rbPrecioProductos.UseVisualStyleBackColor = True
        '
        'rbIdProductos
        '
        Me.rbIdProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbIdProductos.AutoSize = True
        Me.rbIdProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIdProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbIdProductos.Location = New System.Drawing.Point(10, 90)
        Me.rbIdProductos.Name = "rbIdProductos"
        Me.rbIdProductos.Size = New System.Drawing.Size(39, 20)
        Me.rbIdProductos.TabIndex = 0
        Me.rbIdProductos.TabStop = True
        Me.rbIdProductos.Text = "ID"
        Me.rbIdProductos.UseVisualStyleBackColor = True
        '
        'rbCategoriaProductos
        '
        Me.rbCategoriaProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbCategoriaProductos.AutoSize = True
        Me.rbCategoriaProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCategoriaProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbCategoriaProductos.Location = New System.Drawing.Point(10, 180)
        Me.rbCategoriaProductos.Name = "rbCategoriaProductos"
        Me.rbCategoriaProductos.Size = New System.Drawing.Size(85, 20)
        Me.rbCategoriaProductos.TabIndex = 3
        Me.rbCategoriaProductos.TabStop = True
        Me.rbCategoriaProductos.Text = "Categoría"
        Me.rbCategoriaProductos.UseVisualStyleBackColor = True
        '
        'btnLimpiarProductos
        '
        Me.btnLimpiarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLimpiarProductos.FlatAppearance.BorderSize = 0
        Me.btnLimpiarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLimpiarProductos.Location = New System.Drawing.Point(10, 220)
        Me.btnLimpiarProductos.Name = "btnLimpiarProductos"
        Me.btnLimpiarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiarProductos.TabIndex = 4
        Me.btnLimpiarProductos.Text = "Limpiar"
        Me.btnLimpiarProductos.UseVisualStyleBackColor = False
        '
        'lblFiltroProductos
        '
        Me.lblFiltroProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFiltroProductos.AutoSize = True
        Me.lblFiltroProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblFiltroProductos.Location = New System.Drawing.Point(10, 50)
        Me.lblFiltroProductos.Name = "lblFiltroProductos"
        Me.lblFiltroProductos.Size = New System.Drawing.Size(80, 20)
        Me.lblFiltroProductos.TabIndex = 4
        Me.lblFiltroProductos.Text = "Filtrar por:"
        '
        'pnlABM
        '
        Me.pnlABM.Controls.Add(Me.btnEliminarProductos)
        Me.pnlABM.Controls.Add(Me.btnEditarProductos)
        Me.pnlABM.Controls.Add(Me.btnAgregarProductos)
        Me.pnlABM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlABM.Location = New System.Drawing.Point(0, 387)
        Me.pnlABM.Name = "pnlABM"
        Me.pnlABM.Size = New System.Drawing.Size(640, 50)
        Me.pnlABM.TabIndex = 5
        '
        'btnEliminarProductos
        '
        Me.btnEliminarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnEliminarProductos.FlatAppearance.BorderSize = 0
        Me.btnEliminarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnEliminarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEliminarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEliminarProductos.Location = New System.Drawing.Point(526, 10)
        Me.btnEliminarProductos.Name = "btnEliminarProductos"
        Me.btnEliminarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminarProductos.TabIndex = 2
        Me.btnEliminarProductos.Text = "Eliminar"
        Me.btnEliminarProductos.UseVisualStyleBackColor = False
        '
        'btnEditarProductos
        '
        Me.btnEditarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnEditarProductos.FlatAppearance.BorderSize = 0
        Me.btnEditarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditarProductos.Location = New System.Drawing.Point(127, 10)
        Me.btnEditarProductos.Name = "btnEditarProductos"
        Me.btnEditarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnEditarProductos.TabIndex = 1
        Me.btnEditarProductos.Text = "Editar"
        Me.btnEditarProductos.UseVisualStyleBackColor = False
        '
        'btnAgregarProductos
        '
        Me.btnAgregarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarProductos.FlatAppearance.BorderSize = 0
        Me.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAgregarProductos.Location = New System.Drawing.Point(10, 10)
        Me.btnAgregarProductos.Name = "btnAgregarProductos"
        Me.btnAgregarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarProductos.TabIndex = 0
        Me.btnAgregarProductos.Text = "Agregar"
        Me.btnAgregarProductos.UseVisualStyleBackColor = False
        '
        'PnlBuscar
        '
        Me.PnlBuscar.Controls.Add(Me.btnBuscar)
        Me.PnlBuscar.Controls.Add(Me.lblOrdenarProductos)
        Me.PnlBuscar.Controls.Add(Me.cbxOrdenarProductos)
        Me.PnlBuscar.Controls.Add(Me.txtBuscarProductos)
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
        'lblOrdenarProductos
        '
        Me.lblOrdenarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdenarProductos.AutoSize = True
        Me.lblOrdenarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenarProductos.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOrdenarProductos.Location = New System.Drawing.Point(429, 16)
        Me.lblOrdenarProductos.Name = "lblOrdenarProductos"
        Me.lblOrdenarProductos.Size = New System.Drawing.Size(71, 20)
        Me.lblOrdenarProductos.TabIndex = 3
        Me.lblOrdenarProductos.Text = "Ordenar:"
        '
        'cbxOrdenarProductos
        '
        Me.cbxOrdenarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOrdenarProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOrdenarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrdenarProductos.FormattingEnabled = True
        Me.cbxOrdenarProductos.Location = New System.Drawing.Point(516, 13)
        Me.cbxOrdenarProductos.Name = "cbxOrdenarProductos"
        Me.cbxOrdenarProductos.Size = New System.Drawing.Size(121, 26)
        Me.cbxOrdenarProductos.TabIndex = 2
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProductos.Location = New System.Drawing.Point(10, 13)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(300, 26)
        Me.txtBuscarProductos.TabIndex = 0
        '
        'lblProductos
        '
        Me.lblProductos.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblProductos.Location = New System.Drawing.Point(0, 0)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblProductos.Size = New System.Drawing.Size(640, 60)
        Me.lblProductos.TabIndex = 2
        Me.lblProductos.Text = "Productos"
        Me.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.pnlProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmClientes"
        Me.pnlProductos.ResumeLayout(False)
        Me.pnlDgv.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlFiltro.PerformLayout()
        Me.pnlABM.ResumeLayout(False)
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProductos As Panel
    Friend WithEvents lblProductos As Label
    Friend WithEvents PnlBuscar As Panel
    Friend WithEvents pnlABM As Panel
    Friend WithEvents btnEliminarProductos As Button
    Friend WithEvents btnEditarProductos As Button
    Friend WithEvents btnAgregarProductos As Button
    Friend WithEvents txtBuscarProductos As TextBox
    Friend WithEvents cbxOrdenarProductos As ComboBox
    Friend WithEvents lblOrdenarProductos As Label
    Friend WithEvents pnlFiltro As Panel
    Friend WithEvents rbPrecioProductos As RadioButton
    Friend WithEvents rbIdProductos As RadioButton
    Friend WithEvents rbCategoriaProductos As RadioButton
    Friend WithEvents btnLimpiarProductos As Button
    Friend WithEvents lblFiltroProductos As Label
    Friend WithEvents pnlDgv As Panel
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents rbNombreProductos As RadioButton
End Class
