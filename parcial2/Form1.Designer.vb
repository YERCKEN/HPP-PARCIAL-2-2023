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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Menu = New MenuStrip()
        Archivo = New ToolStripMenuItem()
        archivoP1 = New ToolStripMenuItem()
        archivoP2 = New ToolStripMenuItem()
        ArchivoP4 = New ToolStripMenuItem()
        P3 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        ayuda = New ToolStripMenuItem()
        btnEmpresa = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        version = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        BtnCerrar = New PictureBox()
        BtnMin = New PictureBox()
        Menu.SuspendLayout()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.Transparent
        Menu.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Menu.GripMargin = New Padding(2, 60, 60, 2)
        Menu.ImageScalingSize = New Size(20, 20)
        Menu.Items.AddRange(New ToolStripItem() {Archivo, toolStripSeparator5, ayuda, toolStripSeparator2, version})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Padding = New Padding(0)
        Menu.RenderMode = ToolStripRenderMode.Professional
        Menu.Size = New Size(1288, 49)
        Menu.TabIndex = 11
        Menu.Text = "MenuStrip1"
        ' 
        ' Archivo
        ' 
        Archivo.DropDownItems.AddRange(New ToolStripItem() {archivoP1, archivoP2, ArchivoP4, P3, ToolStripSeparator1, SalirToolStripMenuItem})
        Archivo.Margin = New Padding(20, 0, 0, 0)
        Archivo.Name = "Archivo"
        Archivo.Padding = New Padding(5, 20, 5, 0)
        Archivo.Size = New Size(78, 49)
        Archivo.Text = "Menú"
        ' 
        ' archivoP1
        ' 
        archivoP1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP1.ImageTransparentColor = Color.Magenta
        archivoP1.Margin = New Padding(0, 20, 0, 0)
        archivoP1.Name = "archivoP1"
        archivoP1.Padding = New Padding(0, 5, 0, 1)
        archivoP1.Size = New Size(209, 34)
        archivoP1.Text = "Inicio"
        ' 
        ' archivoP2
        ' 
        archivoP2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP2.ImageTransparentColor = Color.Magenta
        archivoP2.Name = "archivoP2"
        archivoP2.Padding = New Padding(0, 5, 0, 1)
        archivoP2.Size = New Size(209, 34)
        archivoP2.Text = "Administrar"
        ' 
        ' ArchivoP4
        ' 
        ArchivoP4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ArchivoP4.Name = "ArchivoP4"
        ArchivoP4.Size = New Size(209, 30)
        ArchivoP4.Text = "Itinerario"
        ' 
        ' P3
        ' 
        P3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        P3.ImageTransparentColor = Color.Magenta
        P3.Name = "P3"
        P3.Padding = New Padding(0, 5, 0, 1)
        P3.Size = New Size(209, 34)
        P3.Text = "Reporte"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(206, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        SalirToolStripMenuItem.Margin = New Padding(0, 15, 0, 0)
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Padding = New Padding(0, 10, 0, 1)
        SalirToolStripMenuItem.Size = New Size(209, 39)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(6, 44)
        ' 
        ' ayuda
        ' 
        ayuda.DropDownItems.AddRange(New ToolStripItem() {btnEmpresa})
        ayuda.Name = "ayuda"
        ayuda.Padding = New Padding(5, 20, 5, 0)
        ayuda.Size = New Size(85, 49)
        ayuda.Text = "Ayuda"
        ' 
        ' btnEmpresa
        ' 
        btnEmpresa.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnEmpresa.Name = "btnEmpresa"
        btnEmpresa.Size = New Size(181, 30)
        btnEmpresa.Text = "Empresa"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 44)
        ' 
        ' version
        ' 
        version.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem})
        version.Name = "version"
        version.Padding = New Padding(5, 20, 5, 0)
        version.Size = New Size(96, 49)
        version.Text = "Version"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BuscarToolStripMenuItem.Margin = New Padding(0, 20, 0, 0)
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(125, 30)
        BuscarToolStripMenuItem.Text = "5.5"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), Image)
        BtnCerrar.Cursor = Cursors.Hand
        BtnCerrar.Location = New Point(1235, 7)
        BtnCerrar.Margin = New Padding(4, 3, 4, 3)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(32, 32)
        BtnCerrar.TabIndex = 14
        BtnCerrar.TabStop = False
        ' 
        ' BtnMin
        ' 
        BtnMin.Cursor = Cursors.Hand
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(1199, 7)
        BtnMin.Margin = New Padding(4, 3, 4, 3)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(32, 32)
        BtnMin.TabIndex = 15
        BtnMin.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 620)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnMin)
        Controls.Add(Menu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Archivo As ToolStripMenuItem
    Friend WithEvents archivoP1 As ToolStripMenuItem
    Friend WithEvents archivoP2 As ToolStripMenuItem
    Friend WithEvents ArchivoP4 As ToolStripMenuItem
    Friend WithEvents P3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ayuda As ToolStripMenuItem
    Friend WithEvents btnEmpresa As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents version As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMin As PictureBox
End Class
