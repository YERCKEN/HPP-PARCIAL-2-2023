<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(empresa))
        PanelEmpresa = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        YK = New Label()
        PanelEmpresa.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelEmpresa
        ' 
        PanelEmpresa.Controls.Add(PictureBox1)
        PanelEmpresa.Controls.Add(Label1)
        PanelEmpresa.Controls.Add(YK)
        PanelEmpresa.Location = New Point(38, 12)
        PanelEmpresa.Name = "PanelEmpresa"
        PanelEmpresa.Size = New Size(1088, 501)
        PanelEmpresa.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(470, 410)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 91)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        Label1.Location = New Point(137, 207)
        Label1.MaximumSize = New Size(0, 451)
        Label1.Name = "Label1"
        Label1.Size = New Size(813, 120)
        Label1.TabIndex = 1
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' YK
        ' 
        YK.AutoSize = True
        YK.Font = New Font("Astrolab", 90F, FontStyle.Regular, GraphicsUnit.Point)
        YK.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        YK.ImageAlign = ContentAlignment.MiddleLeft
        YK.Location = New Point(310, 0)
        YK.Name = "YK"
        YK.Size = New Size(425, 207)
        YK.TabIndex = 0
        YK.Text = "JK"
        ' 
        ' empresa
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1182, 527)
        Controls.Add(PanelEmpresa)
        Name = "empresa"
        Text = "empresa"
        PanelEmpresa.ResumeLayout(False)
        PanelEmpresa.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelEmpresa As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents YK As Label
End Class
