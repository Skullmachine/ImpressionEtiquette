<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bouton_impression = New System.Windows.Forms.Button()
        Me.code_128_grand = New System.Windows.Forms.CheckBox()
        Me.code_128_petit = New System.Windows.Forms.CheckBox()
        Me.datamatrix = New System.Windows.Forms.CheckBox()
        Me.ref_box1 = New System.Windows.Forms.TextBox()
        Me.ref_box2 = New System.Windows.Forms.TextBox()
        Me.mode_manuel = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Références :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "De"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(363, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "à"
        '
        'bouton_impression
        '
        Me.bouton_impression.Location = New System.Drawing.Point(248, 266)
        Me.bouton_impression.Name = "bouton_impression"
        Me.bouton_impression.Size = New System.Drawing.Size(112, 39)
        Me.bouton_impression.TabIndex = 9
        Me.bouton_impression.Text = "Impression"
        Me.bouton_impression.UseVisualStyleBackColor = True
        '
        'code_128_grand
        '
        Me.code_128_grand.AutoSize = True
        Me.code_128_grand.Location = New System.Drawing.Point(109, 141)
        Me.code_128_grand.Name = "code_128_grand"
        Me.code_128_grand.Size = New System.Drawing.Size(135, 17)
        Me.code_128_grand.TabIndex = 10
        Me.code_128_grand.Text = "Code 128 équipements"
        Me.code_128_grand.UseVisualStyleBackColor = True
        '
        'code_128_petit
        '
        Me.code_128_petit.AutoSize = True
        Me.code_128_petit.Location = New System.Drawing.Point(265, 141)
        Me.code_128_petit.Name = "code_128_petit"
        Me.code_128_petit.Size = New System.Drawing.Size(145, 17)
        Me.code_128_petit.TabIndex = 11
        Me.code_128_petit.Text = "Code 128 consommables"
        Me.code_128_petit.UseVisualStyleBackColor = True
        '
        'datamatrix
        '
        Me.datamatrix.AutoSize = True
        Me.datamatrix.Location = New System.Drawing.Point(425, 141)
        Me.datamatrix.Name = "datamatrix"
        Me.datamatrix.Size = New System.Drawing.Size(139, 17)
        Me.datamatrix.TabIndex = 12
        Me.datamatrix.Text = "Datamatrix équipements"
        Me.datamatrix.UseVisualStyleBackColor = True
        '
        'ref_box1
        '
        Me.ref_box1.Enabled = False
        Me.ref_box1.Location = New System.Drawing.Point(174, 189)
        Me.ref_box1.MaxLength = 6
        Me.ref_box1.Name = "ref_box1"
        Me.ref_box1.Size = New System.Drawing.Size(100, 20)
        Me.ref_box1.TabIndex = 13
        '
        'ref_box2
        '
        Me.ref_box2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ref_box2.Location = New System.Drawing.Point(382, 189)
        Me.ref_box2.MaxLength = 6
        Me.ref_box2.Name = "ref_box2"
        Me.ref_box2.Size = New System.Drawing.Size(100, 20)
        Me.ref_box2.TabIndex = 14
        '
        'mode_manuel
        '
        Me.mode_manuel.AutoSize = True
        Me.mode_manuel.Location = New System.Drawing.Point(265, 87)
        Me.mode_manuel.Name = "mode_manuel"
        Me.mode_manuel.Size = New System.Drawing.Size(91, 17)
        Me.mode_manuel.TabIndex = 15
        Me.mode_manuel.Text = "Mode Manuel"
        Me.mode_manuel.UseVisualStyleBackColor = True
        '
        'fenetre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 342)
        Me.Controls.Add(Me.mode_manuel)
        Me.Controls.Add(Me.ref_box2)
        Me.Controls.Add(Me.ref_box1)
        Me.Controls.Add(Me.datamatrix)
        Me.Controls.Add(Me.code_128_petit)
        Me.Controls.Add(Me.code_128_grand)
        Me.Controls.Add(Me.bouton_impression)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fenetre"
        Me.Text = "Impression d'étiquettes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bouton_impression As System.Windows.Forms.Button
    Friend WithEvents code_128_grand As System.Windows.Forms.CheckBox
    Friend WithEvents code_128_petit As System.Windows.Forms.CheckBox
    Friend WithEvents datamatrix As System.Windows.Forms.CheckBox
    Friend WithEvents ref_box1 As System.Windows.Forms.TextBox
    Friend WithEvents ref_box2 As System.Windows.Forms.TextBox
    Friend WithEvents mode_manuel As System.Windows.Forms.CheckBox

End Class
