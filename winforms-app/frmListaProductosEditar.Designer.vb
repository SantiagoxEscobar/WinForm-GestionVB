<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaProductosEditar
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
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPrecioUnitario = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.btnConfirmarProductos = New System.Windows.Forms.Button()
        Me.btnCancelarProductos = New System.Windows.Forms.Button()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblAsterisco2 = New System.Windows.Forms.Label()
        Me.nupCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProducto.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblIdProducto.Location = New System.Drawing.Point(28, 23)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(30, 20)
        Me.lblIdProducto.TabIndex = 0
        Me.lblIdProducto.Text = "ID:"
        Me.lblIdProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCantidad.Location = New System.Drawing.Point(31, 73)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(77, 20)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrecioUnitario.AutoSize = True
        Me.lblPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioUnitario.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(28, 163)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(116, 20)
        Me.lblPrecioUnitario.TabIndex = 2
        Me.lblPrecioUnitario.Text = "Precio Unitario:"
        Me.lblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Location = New System.Drawing.Point(150, 20)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 26)
        Me.txtIdProducto.TabIndex = 3
        '
        'btnConfirmarProductos
        '
        Me.btnConfirmarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirmarProductos.FlatAppearance.BorderSize = 0
        Me.btnConfirmarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirmarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConfirmarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnConfirmarProductos.Location = New System.Drawing.Point(35, 210)
        Me.btnConfirmarProductos.Name = "btnConfirmarProductos"
        Me.btnConfirmarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnConfirmarProductos.TabIndex = 9
        Me.btnConfirmarProductos.Text = "Confirmar"
        Me.btnConfirmarProductos.UseVisualStyleBackColor = False
        '
        'btnCancelarProductos
        '
        Me.btnCancelarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnCancelarProductos.FlatAppearance.BorderSize = 0
        Me.btnCancelarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancelarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancelarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCancelarProductos.Location = New System.Drawing.Point(480, 210)
        Me.btnCancelarProductos.Name = "btnCancelarProductos"
        Me.btnCancelarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelarProductos.TabIndex = 10
        Me.btnCancelarProductos.Text = "Cancelar"
        Me.btnCancelarProductos.UseVisualStyleBackColor = False
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAdvertencia.Location = New System.Drawing.Point(32, 115)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(548, 16)
        Me.lblAdvertencia.TabIndex = 11
        Me.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = True
        Me.lblAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAsterisco.Location = New System.Drawing.Point(54, 17)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(20, 25)
        Me.lblAsterisco.TabIndex = 12
        Me.lblAsterisco.Text = "*"
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(380, 70)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(200, 26)
        Me.txtCategoria.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(380, 20)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(200, 26)
        Me.txtNombre.TabIndex = 15
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNombre.Location = New System.Drawing.Point(280, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCategoria
        '
        Me.lblCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCategoria.Location = New System.Drawing.Point(280, 72)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 13
        Me.lblCategoria.Text = "Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioTotal.Location = New System.Drawing.Point(380, 160)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(200, 26)
        Me.txtPrecioTotal.TabIndex = 18
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPrecioTotal.Location = New System.Drawing.Point(280, 163)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(96, 20)
        Me.lblPrecioTotal.TabIndex = 17
        Me.lblPrecioTotal.Text = "Precio Total:"
        Me.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAsterisco2
        '
        Me.lblAsterisco2.AutoSize = True
        Me.lblAsterisco2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAsterisco2.Location = New System.Drawing.Point(100, 68)
        Me.lblAsterisco2.Name = "lblAsterisco2"
        Me.lblAsterisco2.Size = New System.Drawing.Size(20, 25)
        Me.lblAsterisco2.TabIndex = 19
        Me.lblAsterisco2.Text = "*"
        '
        'nupCantidad
        '
        Me.nupCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nupCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupCantidad.Location = New System.Drawing.Point(150, 71)
        Me.nupCantidad.Name = "nupCantidad"
        Me.nupCantidad.ReadOnly = True
        Me.nupCantidad.Size = New System.Drawing.Size(100, 26)
        Me.nupCantidad.TabIndex = 20
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(150, 160)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.ReadOnly = True
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(100, 26)
        Me.txtPrecioUnitario.TabIndex = 21
        '
        'frmListaProductosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 261)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.nupCantidad)
        Me.Controls.Add(Me.lblAsterisco2)
        Me.Controls.Add(Me.txtPrecioTotal)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblAsterisco)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.btnCancelarProductos)
        Me.Controls.Add(Me.btnConfirmarProductos)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.lblPrecioUnitario)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblIdProducto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(760, 300)
        Me.Name = "frmListaProductosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Producto"
        CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdProducto As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPrecioUnitario As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents btnConfirmarProductos As Button
    Friend WithEvents btnCancelarProductos As Button
    Friend WithEvents lblAdvertencia As Label
    Friend WithEvents lblAsterisco As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblAsterisco2 As Label
    Friend WithEvents nupCantidad As NumericUpDown
    Friend WithEvents txtPrecioUnitario As TextBox
End Class
