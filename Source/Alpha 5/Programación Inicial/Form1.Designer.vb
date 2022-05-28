<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BotonDeIngreso = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BotonDeIngreso
        '
        resources.ApplyResources(Me.BotonDeIngreso, "BotonDeIngreso")
        Me.BotonDeIngreso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonDeIngreso.Name = "BotonDeIngreso"
        Me.BotonDeIngreso.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Programación_Inicial.My.Resources.Resources.Logo
        Me.Controls.Add(Me.BotonDeIngreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonDeIngreso As Button
End Class
