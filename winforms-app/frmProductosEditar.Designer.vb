<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductosEditar
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnEditarProductos = New System.Windows.Forms.Button()
        Me.btnCancelarProductos = New System.Windows.Forms.Button()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNombre.Location = New System.Drawing.Point(31, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblCategoria.Location = New System.Drawing.Point(31, 123)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(82, 20)
        Me.lblCategoria.TabIndex = 1
        Me.lblCategoria.Text = "Categoría:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPrecio.Location = New System.Drawing.Point(31, 73)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(150, 20)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 26)
        Me.txtNombre.TabIndex = 3
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(150, 70)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(250, 26)
        Me.txtPrecio.TabIndex = 4
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(150, 120)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(250, 26)
        Me.txtCategoria.TabIndex = 5
        '
        'btnEditarProductos
        '
        Me.btnEditarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarProductos.FlatAppearance.BorderSize = 0
        Me.btnEditarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEditarProductos.Location = New System.Drawing.Point(35, 190)
        Me.btnEditarProductos.Name = "btnEditarProductos"
        Me.btnEditarProductos.Size = New System.Drawing.Size(100, 30)
        Me.btnEditarProductos.TabIndex = 9
        Me.btnEditarProductos.Text = "Confirmar"
        Me.btnEditarProductos.UseVisualStyleBackColor = False
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
        Me.btnCancelarProductos.Location = New System.Drawing.Point(300, 190)
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
        Me.lblAsterisco.Location = New System.Drawing.Point(95, 18)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(20, 25)
        Me.lblAsterisco.TabIndex = 12
        Me.lblAsterisco.Text = "*"
        '
        'frmProductosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 241)
        Me.Controls.Add(Me.lblAsterisco)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.btnCancelarProductos)
        Me.Controls.Add(Me.btnEditarProductos)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblNombre)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 280)
        Me.Name = "frmProductosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnEditarProductos As Button
    Friend WithEvents btnCancelarProductos As Button
    Friend WithEvents lblAdvertencia As Label
    Friend WithEvents lblAsterisco As Label
End Class
