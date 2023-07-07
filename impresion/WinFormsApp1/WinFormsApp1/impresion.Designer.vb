<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresion
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
        BtnFactura = New Button()
        DataGridView1 = New DataGridView()
        PanelSelecion = New Panel()
        TextBoxId = New TextBox()
        Label9 = New Label()
        BtnSeleccionarTicket = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelSelecion.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnFactura
        ' 
        BtnFactura.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnFactura.Cursor = Cursors.Hand
        BtnFactura.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnFactura.FlatAppearance.BorderSize = 0
        BtnFactura.FlatStyle = FlatStyle.Flat
        BtnFactura.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnFactura.ForeColor = Color.White
        BtnFactura.Location = New Point(632, 109)
        BtnFactura.Name = "BtnFactura"
        BtnFactura.Size = New Size(345, 51)
        BtnFactura.TabIndex = 59
        BtnFactura.Text = "Imprimir Factura.xlsx"
        BtnFactura.UseVisualStyleBackColor = False
        BtnFactura.Visible = False
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
        DataGridView1.Location = New Point(30, 210)
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
        DataGridView1.Size = New Size(947, 262)
        DataGridView1.TabIndex = 60
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Controls.Add(BtnSeleccionarTicket)
        PanelSelecion.Location = New Point(82, 68)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 116)
        PanelSelecion.TabIndex = 70
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxId.Location = New Point(18, 47)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(175, 36)
        TextBoxId.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(18, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 25)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' BtnSeleccionarTicket
        ' 
        BtnSeleccionarTicket.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSeleccionarTicket.Cursor = Cursors.Hand
        BtnSeleccionarTicket.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSeleccionarTicket.FlatAppearance.BorderSize = 0
        BtnSeleccionarTicket.FlatStyle = FlatStyle.Flat
        BtnSeleccionarTicket.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeleccionarTicket.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSeleccionarTicket.Location = New Point(215, 29)
        BtnSeleccionarTicket.Name = "BtnSeleccionarTicket"
        BtnSeleccionarTicket.Size = New Size(181, 72)
        BtnSeleccionarTicket.TabIndex = 72
        BtnSeleccionarTicket.Text = "Seleccionar Ticket"
        BtnSeleccionarTicket.UseVisualStyleBackColor = False
        ' 
        ' impresion
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1016, 511)
        Controls.Add(PanelSelecion)
        Controls.Add(DataGridView1)
        Controls.Add(BtnFactura)
        Name = "impresion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "impresion"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BtnFactura As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSeleccionarTicket As Button
End Class
