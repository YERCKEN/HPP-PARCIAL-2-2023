<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminaciónCliente
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelConfirmación = New Panel()
        BtnAceptarEliminacion = New Button()
        BtnCancelar = New Button()
        LabelMensaje = New Label()
        PanelSelecion = New Panel()
        TextBoxBusquedad = New TextBox()
        Label8 = New Label()
        TextBoxId = New TextBox()
        Label9 = New Label()
        BtnEliminar = New Button()
        DataGridView1 = New DataGridView()
        PanelConfirmación.SuspendLayout()
        PanelSelecion.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelConfirmación
        ' 
        PanelConfirmación.AllowDrop = True
        PanelConfirmación.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        PanelConfirmación.Controls.Add(BtnAceptarEliminacion)
        PanelConfirmación.Controls.Add(BtnCancelar)
        PanelConfirmación.Controls.Add(LabelMensaje)
        PanelConfirmación.Location = New Point(95, 196)
        PanelConfirmación.Name = "PanelConfirmación"
        PanelConfirmación.Size = New Size(475, 165)
        PanelConfirmación.TabIndex = 71
        PanelConfirmación.Visible = False
        ' 
        ' BtnAceptarEliminacion
        ' 
        BtnAceptarEliminacion.BackColor = Color.White
        BtnAceptarEliminacion.Cursor = Cursors.Hand
        BtnAceptarEliminacion.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnAceptarEliminacion.FlatAppearance.BorderSize = 0
        BtnAceptarEliminacion.FlatStyle = FlatStyle.Flat
        BtnAceptarEliminacion.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAceptarEliminacion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnAceptarEliminacion.Location = New Point(91, 108)
        BtnAceptarEliminacion.Name = "BtnAceptarEliminacion"
        BtnAceptarEliminacion.Size = New Size(144, 41)
        BtnAceptarEliminacion.TabIndex = 64
        BtnAceptarEliminacion.Text = "Aceptar"
        BtnAceptarEliminacion.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        BtnCancelar.Cursor = Cursors.Hand
        BtnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(241, 108)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(144, 41)
        BtnCancelar.TabIndex = 63
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' LabelMensaje
        ' 
        LabelMensaje.AutoSize = True
        LabelMensaje.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        LabelMensaje.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelMensaje.ForeColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        LabelMensaje.Location = New Point(20, 7)
        LabelMensaje.MaximumSize = New Size(429, 80)
        LabelMensaje.Name = "LabelMensaje"
        LabelMensaje.Padding = New Padding(20, 5, 20, 5)
        LabelMensaje.Size = New Size(429, 80)
        LabelMensaje.TabIndex = 62
        LabelMensaje.Text = "¿ Seguro quieres eliminar el " & vbCrLf & "Usuario con ID: 1 ?"
        LabelMensaje.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(TextBoxBusquedad)
        PanelSelecion.Controls.Add(Label8)
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Controls.Add(BtnEliminar)
        PanelSelecion.Location = New Point(119, 157)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 239)
        PanelSelecion.TabIndex = 69
        ' 
        ' TextBoxBusquedad
        ' 
        TextBoxBusquedad.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxBusquedad.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxBusquedad.Location = New Point(19, 53)
        TextBoxBusquedad.Name = "TextBoxBusquedad"
        TextBoxBusquedad.Size = New Size(388, 36)
        TextBoxBusquedad.TabIndex = 74
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label8.Location = New Point(19, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(159, 25)
        Label8.TabIndex = 75
        Label8.Text = "Buscar Usuario"
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxId.Location = New Point(19, 172)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(175, 36)
        TextBoxId.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(19, 144)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 25)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEliminar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnEliminar.Location = New Point(226, 167)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(181, 46)
        BtnEliminar.TabIndex = 72
        BtnEliminar.Text = "Eliminar Ticket"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(724, 111)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(439, 381)
        DataGridView1.TabIndex = 73
        ' 
        ' eliminaciónCliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 572)
        Controls.Add(DataGridView1)
        Controls.Add(PanelSelecion)
        Controls.Add(PanelConfirmación)
        FormBorderStyle = FormBorderStyle.None
        Name = "eliminaciónCliente"
        Text = "eliminaciónCliente"
        PanelConfirmación.ResumeLayout(False)
        PanelConfirmación.PerformLayout()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelConfirmación As Panel
    Friend WithEvents BtnAceptarEliminacion As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxBusquedad As TextBox
End Class
