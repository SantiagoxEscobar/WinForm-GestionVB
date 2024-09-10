<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.lblHome1 = New System.Windows.Forms.Label()
        Me.lblHome2 = New System.Windows.Forms.Label()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlHome.Controls.Add(Me.lblHome1)
        Me.pnlHome.Controls.Add(Me.lblHome2)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlHome.Location = New System.Drawing.Point(180, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(640, 457)
        Me.pnlHome.TabIndex = 3
        '
        'lblHome1
        '
        Me.lblHome1.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHome1.Location = New System.Drawing.Point(0, 0)
        Me.lblHome1.Name = "lblHome1"
        Me.lblHome1.Size = New System.Drawing.Size(640, 237)
        Me.lblHome1.TabIndex = 2
        Me.lblHome1.Text = "Bienvenido al programa de gestión TacticaSoft" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHome1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblHome2
        '
        Me.lblHome2.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblHome2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHome2.Location = New System.Drawing.Point(0, 257)
        Me.lblHome2.Name = "lblHome2"
        Me.lblHome2.Size = New System.Drawing.Size(640, 200)
        Me.lblHome2.TabIndex = 1
        Me.lblHome2.Text = "Por favor, seleccione las funciones que desea utilizar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verifique sus modificaci" &
    "ones." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmHome"
        Me.pnlHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHome As Panel
    Friend WithEvents lblHome1 As Label
    Friend WithEvents lblHome2 As Label
End Class
