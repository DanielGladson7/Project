<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SolidStateLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(44, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thermodynamics"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Turquoise
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(44, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modern Physics"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Wheat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(54, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 49)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Waves and Optics"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(526, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 49)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mechanics"
        '
        'SolidStateLbl
        '
        Me.SolidStateLbl.AutoSize = True
        Me.SolidStateLbl.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SolidStateLbl.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SolidStateLbl.Location = New System.Drawing.Point(526, 231)
        Me.SolidStateLbl.Name = "SolidStateLbl"
        Me.SolidStateLbl.Size = New System.Drawing.Size(208, 49)
        Me.SolidStateLbl.TabIndex = 4
        Me.SolidStateLbl.Text = "Solid State"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Orchid
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(526, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 49)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Astrophysics"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(880, 530)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SolidStateLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEMO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SolidStateLbl As Label
    Friend WithEvents Label6 As Label
End Class
