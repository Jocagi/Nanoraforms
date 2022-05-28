<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mapa_tablero
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mapa_tablero))
        Me.C133 = New System.Windows.Forms.CheckBox()
        Me.Enviar = New System.Windows.Forms.Button()
        Me.PiezaA = New System.Windows.Forms.CheckBox()
        Me.PiezaB = New System.Windows.Forms.CheckBox()
        Me.PiezaC = New System.Windows.Forms.CheckBox()
        Me.C123 = New System.Windows.Forms.CheckBox()
        Me.C223 = New System.Windows.Forms.CheckBox()
        Me.C213 = New System.Windows.Forms.CheckBox()
        Me.C313 = New System.Windows.Forms.CheckBox()
        Me.C122 = New System.Windows.Forms.CheckBox()
        Me.C112 = New System.Windows.Forms.CheckBox()
        Me.C212 = New System.Windows.Forms.CheckBox()
        Me.C111 = New System.Windows.Forms.CheckBox()
        Me.Comunicacion = New System.IO.Ports.SerialPort(Me.components)
        Me.Conectar = New System.Windows.Forms.Button()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MapaTablero = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MapaTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C133
        '
        Me.C133.Appearance = System.Windows.Forms.Appearance.Button
        Me.C133.AutoSize = True
        Me.C133.BackColor = System.Drawing.Color.White
        Me.C133.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C133.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C133.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C133.Location = New System.Drawing.Point(43, 56)
        Me.C133.Name = "C133"
        Me.C133.Size = New System.Drawing.Size(41, 23)
        Me.C133.TabIndex = 2
        Me.C133.Text = "1,3,3"
        Me.C133.UseVisualStyleBackColor = False
        '
        'Enviar
        '
        Me.Enviar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Enviar.Location = New System.Drawing.Point(469, 238)
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(97, 36)
        Me.Enviar.TabIndex = 3
        Me.Enviar.Text = "Enviar"
        Me.Enviar.UseMnemonic = False
        Me.Enviar.UseVisualStyleBackColor = True
        '
        'PiezaA
        '
        Me.PiezaA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PiezaA.Appearance = System.Windows.Forms.Appearance.Button
        Me.PiezaA.AutoSize = True
        Me.PiezaA.BackColor = System.Drawing.Color.White
        Me.PiezaA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.PiezaA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PiezaA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PiezaA.Location = New System.Drawing.Point(380, 151)
        Me.PiezaA.Name = "PiezaA"
        Me.PiezaA.Size = New System.Drawing.Size(24, 23)
        Me.PiezaA.TabIndex = 4
        Me.PiezaA.Text = "A"
        Me.PiezaA.UseVisualStyleBackColor = False
        '
        'PiezaB
        '
        Me.PiezaB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PiezaB.Appearance = System.Windows.Forms.Appearance.Button
        Me.PiezaB.AutoSize = True
        Me.PiezaB.BackColor = System.Drawing.Color.White
        Me.PiezaB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.PiezaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PiezaB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PiezaB.Location = New System.Drawing.Point(426, 151)
        Me.PiezaB.Name = "PiezaB"
        Me.PiezaB.Size = New System.Drawing.Size(24, 23)
        Me.PiezaB.TabIndex = 5
        Me.PiezaB.Text = "B"
        Me.PiezaB.UseVisualStyleBackColor = False
        '
        'PiezaC
        '
        Me.PiezaC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PiezaC.Appearance = System.Windows.Forms.Appearance.Button
        Me.PiezaC.AutoSize = True
        Me.PiezaC.BackColor = System.Drawing.Color.White
        Me.PiezaC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.PiezaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PiezaC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PiezaC.Location = New System.Drawing.Point(469, 151)
        Me.PiezaC.Name = "PiezaC"
        Me.PiezaC.Size = New System.Drawing.Size(24, 23)
        Me.PiezaC.TabIndex = 6
        Me.PiezaC.Text = "C"
        Me.PiezaC.UseVisualStyleBackColor = False
        '
        'C123
        '
        Me.C123.Appearance = System.Windows.Forms.Appearance.Button
        Me.C123.AutoSize = True
        Me.C123.BackColor = System.Drawing.Color.White
        Me.C123.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C123.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C123.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C123.Location = New System.Drawing.Point(97, 93)
        Me.C123.Name = "C123"
        Me.C123.Size = New System.Drawing.Size(41, 23)
        Me.C123.TabIndex = 10
        Me.C123.Text = "1,2,3"
        Me.C123.UseVisualStyleBackColor = False
        '
        'C223
        '
        Me.C223.Appearance = System.Windows.Forms.Appearance.Button
        Me.C223.AutoSize = True
        Me.C223.BackColor = System.Drawing.Color.White
        Me.C223.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C223.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C223.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C223.Location = New System.Drawing.Point(146, 56)
        Me.C223.Name = "C223"
        Me.C223.Size = New System.Drawing.Size(41, 23)
        Me.C223.TabIndex = 11
        Me.C223.Text = "2,2,3"
        Me.C223.UseVisualStyleBackColor = False
        '
        'C213
        '
        Me.C213.Appearance = System.Windows.Forms.Appearance.Button
        Me.C213.AutoSize = True
        Me.C213.BackColor = System.Drawing.Color.White
        Me.C213.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C213.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C213.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C213.Location = New System.Drawing.Point(202, 93)
        Me.C213.Name = "C213"
        Me.C213.Size = New System.Drawing.Size(41, 23)
        Me.C213.TabIndex = 12
        Me.C213.Text = "2,1,3"
        Me.C213.UseVisualStyleBackColor = False
        '
        'C313
        '
        Me.C313.Appearance = System.Windows.Forms.Appearance.Button
        Me.C313.AutoSize = True
        Me.C313.BackColor = System.Drawing.Color.White
        Me.C313.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C313.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C313.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C313.Location = New System.Drawing.Point(251, 56)
        Me.C313.Name = "C313"
        Me.C313.Size = New System.Drawing.Size(41, 23)
        Me.C313.TabIndex = 13
        Me.C313.Text = "3,1,3"
        Me.C313.UseVisualStyleBackColor = False
        '
        'C122
        '
        Me.C122.Appearance = System.Windows.Forms.Appearance.Button
        Me.C122.AutoSize = True
        Me.C122.BackColor = System.Drawing.Color.White
        Me.C122.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C122.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C122.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C122.Location = New System.Drawing.Point(97, 151)
        Me.C122.Name = "C122"
        Me.C122.Size = New System.Drawing.Size(41, 23)
        Me.C122.TabIndex = 14
        Me.C122.Text = "1,2,2"
        Me.C122.UseVisualStyleBackColor = False
        '
        'C112
        '
        Me.C112.Appearance = System.Windows.Forms.Appearance.Button
        Me.C112.AutoSize = True
        Me.C112.BackColor = System.Drawing.Color.White
        Me.C112.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C112.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C112.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C112.Location = New System.Drawing.Point(146, 182)
        Me.C112.Name = "C112"
        Me.C112.Size = New System.Drawing.Size(41, 23)
        Me.C112.TabIndex = 15
        Me.C112.Text = "1,1,2"
        Me.C112.UseVisualStyleBackColor = False
        '
        'C212
        '
        Me.C212.Appearance = System.Windows.Forms.Appearance.Button
        Me.C212.AutoSize = True
        Me.C212.BackColor = System.Drawing.Color.White
        Me.C212.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C212.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C212.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C212.Location = New System.Drawing.Point(202, 151)
        Me.C212.Name = "C212"
        Me.C212.Size = New System.Drawing.Size(41, 23)
        Me.C212.TabIndex = 19
        Me.C212.Text = "2,1,2"
        Me.C212.UseVisualStyleBackColor = False
        '
        'C111
        '
        Me.C111.Appearance = System.Windows.Forms.Appearance.Button
        Me.C111.AutoSize = True
        Me.C111.BackColor = System.Drawing.Color.White
        Me.C111.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.C111.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C111.ForeColor = System.Drawing.SystemColors.ControlText
        Me.C111.Location = New System.Drawing.Point(146, 238)
        Me.C111.Name = "C111"
        Me.C111.Size = New System.Drawing.Size(41, 23)
        Me.C111.TabIndex = 20
        Me.C111.Text = "1,1,1"
        Me.C111.UseVisualStyleBackColor = False
        '
        'Comunicacion
        '
        Me.Comunicacion.PortName = "COM4"
        '
        'Conectar
        '
        Me.Conectar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Conectar.Location = New System.Drawing.Point(504, 37)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(75, 23)
        Me.Conectar.TabIndex = 22
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(501, 66)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(7, 13)
        Me.lblestado.TabIndex = 23
        Me.lblestado.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(426, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.Text = "COM4"
        '
        'MapaTablero
        '
        Me.MapaTablero.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MapaTablero.BackColor = System.Drawing.SystemColors.Control
        Me.MapaTablero.BackgroundImage = Global.Programación_Inicial.My.Resources.Resources.Mapa_del_tablero_Final_Rotado
        Me.MapaTablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MapaTablero.Location = New System.Drawing.Point(12, 35)
        Me.MapaTablero.Name = "MapaTablero"
        Me.MapaTablero.Size = New System.Drawing.Size(309, 273)
        Me.MapaTablero.TabIndex = 0
        Me.MapaTablero.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Selecciona una Figura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "¿Dónde quieres mover la figura?"
        '
        'Mapa_tablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(591, 343)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.Conectar)
        Me.Controls.Add(Me.C111)
        Me.Controls.Add(Me.C212)
        Me.Controls.Add(Me.C112)
        Me.Controls.Add(Me.C122)
        Me.Controls.Add(Me.C313)
        Me.Controls.Add(Me.C213)
        Me.Controls.Add(Me.C223)
        Me.Controls.Add(Me.C123)
        Me.Controls.Add(Me.PiezaC)
        Me.Controls.Add(Me.PiezaB)
        Me.Controls.Add(Me.PiezaA)
        Me.Controls.Add(Me.Enviar)
        Me.Controls.Add(Me.C133)
        Me.Controls.Add(Me.MapaTablero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Mapa_tablero"
        Me.Text = " NanoraForms"
        CType(Me.MapaTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MapaTablero As PictureBox
    Friend WithEvents C133 As CheckBox
    Friend WithEvents Enviar As Button
    Friend WithEvents PiezaA As CheckBox
    Friend WithEvents PiezaB As CheckBox
    Friend WithEvents PiezaC As CheckBox
    Friend WithEvents C123 As CheckBox
    Friend WithEvents C223 As CheckBox
    Friend WithEvents C213 As CheckBox
    Friend WithEvents C313 As CheckBox
    Friend WithEvents C122 As CheckBox
    Friend WithEvents C112 As CheckBox
    Friend WithEvents C212 As CheckBox
    Friend WithEvents C111 As CheckBox
    Friend WithEvents Comunicacion As IO.Ports.SerialPort
    Friend WithEvents Conectar As Button
    Friend WithEvents lblestado As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
