<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTesting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.txtcelda = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnleer = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblCeldaPos = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(24, 13)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(100, 20)
        Me.txtruta.TabIndex = 0
        Me.txtruta.Text = "ruta"
        '
        'txtcelda
        '
        Me.txtcelda.Location = New System.Drawing.Point(36, 69)
        Me.txtcelda.Name = "txtcelda"
        Me.txtcelda.Size = New System.Drawing.Size(100, 20)
        Me.txtcelda.TabIndex = 1
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(36, 96)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 20)
        Me.txtvalor.TabIndex = 2
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(162, 9)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(37, 23)
        Me.btnAbrir.TabIndex = 3
        Me.btnAbrir.Text = "..."
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnleer
        '
        Me.btnleer.Location = New System.Drawing.Point(175, 69)
        Me.btnleer.Name = "btnleer"
        Me.btnleer.Size = New System.Drawing.Size(75, 23)
        Me.btnleer.TabIndex = 4
        Me.btnleer.Text = "Leer"
        Me.btnleer.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(175, 92)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblCeldaPos
        '
        Me.lblCeldaPos.AutoSize = True
        Me.lblCeldaPos.Font = New System.Drawing.Font("Miramonte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCeldaPos.Location = New System.Drawing.Point(97, 162)
        Me.lblCeldaPos.Name = "lblCeldaPos"
        Me.lblCeldaPos.Size = New System.Drawing.Size(36, 26)
        Me.lblCeldaPos.TabIndex = 6
        Me.lblCeldaPos.Text = "A1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(102, 206)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCeldaPos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnleer)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.txtcelda)
        Me.Controls.Add(Me.txtruta)
        Me.Name = "FrmTesting"
        Me.Text = "FrmTesting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents txtcelda As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents btnleer As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblCeldaPos As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
