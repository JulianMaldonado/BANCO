﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Empleados
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
        Me.components = New System.ComponentModel.Container()
        Dim IDPUESTOLabel As System.Windows.Forms.Label
        Dim IDEPTOPLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim USUARIOLabel As System.Windows.Forms.Label
        Dim CONTRASENALabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONTRASENATextBox = New System.Windows.Forms.TextBox()
        Me.USUARIOTextBox = New System.Windows.Forms.TextBox()
        Me.DPITextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox = New System.Windows.Forms.TextBox()
        Me.IDEPTOPComboBox = New System.Windows.Forms.ComboBox()
        Me.IDPUESTOComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btUPDATE = New System.Windows.Forms.Button()
        Me.EMPLEADODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New Banco.DS()
        Me.EMPLEADOTableAdapter = New Banco.DSTableAdapters.EMPLEADOTableAdapter()
        Me.TableAdapterManager = New Banco.DSTableAdapters.TableAdapterManager()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        IDPUESTOLabel = New System.Windows.Forms.Label()
        IDEPTOPLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        USUARIOLabel = New System.Windows.Forms.Label()
        CONTRASENALabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.EMPLEADODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDPUESTOLabel
        '
        IDPUESTOLabel.AutoSize = True
        IDPUESTOLabel.Location = New System.Drawing.Point(29, 98)
        IDPUESTOLabel.Name = "IDPUESTOLabel"
        IDPUESTOLabel.Size = New System.Drawing.Size(54, 13)
        IDPUESTOLabel.TabIndex = 0
        IDPUESTOLabel.Text = "PUESTO:"
        '
        'IDEPTOPLabel
        '
        IDEPTOPLabel.AutoSize = True
        IDEPTOPLabel.Location = New System.Drawing.Point(29, 63)
        IDEPTOPLabel.Name = "IDEPTOPLabel"
        IDEPTOPLabel.Size = New System.Drawing.Size(100, 13)
        IDEPTOPLabel.TabIndex = 2
        IDEPTOPLabel.Text = "DEPARTAMENTO:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(29, 131)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 4
        NOMBRELabel.Text = "NOMBRE:"
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.Location = New System.Drawing.Point(31, 162)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(62, 13)
        APELLIDOLabel.TabIndex = 6
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(299, 63)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(28, 13)
        DPILabel.TabIndex = 8
        DPILabel.Text = "DPI:"
        '
        'USUARIOLabel
        '
        USUARIOLabel.AutoSize = True
        USUARIOLabel.Location = New System.Drawing.Point(299, 108)
        USUARIOLabel.Name = "USUARIOLabel"
        USUARIOLabel.Size = New System.Drawing.Size(59, 13)
        USUARIOLabel.TabIndex = 10
        USUARIOLabel.Text = "USUARIO:"
        '
        'CONTRASENALabel
        '
        CONTRASENALabel.AutoSize = True
        CONTRASENALabel.Location = New System.Drawing.Point(299, 146)
        CONTRASENALabel.Name = "CONTRASENALabel"
        CONTRASENALabel.Size = New System.Drawing.Size(84, 13)
        CONTRASENALabel.TabIndex = 12
        CONTRASENALabel.Text = "CONTRASENA:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(951, 402)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btGuardar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(CONTRASENALabel)
        Me.TabPage1.Controls.Add(Me.CONTRASENATextBox)
        Me.TabPage1.Controls.Add(USUARIOLabel)
        Me.TabPage1.Controls.Add(Me.USUARIOTextBox)
        Me.TabPage1.Controls.Add(DPILabel)
        Me.TabPage1.Controls.Add(Me.DPITextBox)
        Me.TabPage1.Controls.Add(APELLIDOLabel)
        Me.TabPage1.Controls.Add(Me.APELLIDOTextBox)
        Me.TabPage1.Controls.Add(NOMBRELabel)
        Me.TabPage1.Controls.Add(Me.NOMBRETextBox)
        Me.TabPage1.Controls.Add(IDEPTOPLabel)
        Me.TabPage1.Controls.Add(Me.IDEPTOPComboBox)
        Me.TabPage1.Controls.Add(IDPUESTOLabel)
        Me.TabPage1.Controls.Add(Me.IDPUESTOComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(943, 376)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AGREGAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.Location = New System.Drawing.Point(389, 202)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(131, 46)
        Me.btGuardar.TabIndex = 15
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nuevo Empleado"
        '
        'CONTRASENATextBox
        '
        Me.CONTRASENATextBox.Location = New System.Drawing.Point(389, 143)
        Me.CONTRASENATextBox.Name = "CONTRASENATextBox"
        Me.CONTRASENATextBox.Size = New System.Drawing.Size(131, 20)
        Me.CONTRASENATextBox.TabIndex = 13
        '
        'USUARIOTextBox
        '
        Me.USUARIOTextBox.Location = New System.Drawing.Point(389, 105)
        Me.USUARIOTextBox.Name = "USUARIOTextBox"
        Me.USUARIOTextBox.Size = New System.Drawing.Size(131, 20)
        Me.USUARIOTextBox.TabIndex = 11
        '
        'DPITextBox
        '
        Me.DPITextBox.Location = New System.Drawing.Point(389, 63)
        Me.DPITextBox.Name = "DPITextBox"
        Me.DPITextBox.Size = New System.Drawing.Size(131, 20)
        Me.DPITextBox.TabIndex = 9
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(136, 159)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(120, 20)
        Me.APELLIDOTextBox.TabIndex = 7
        '
        'NOMBRETextBox
        '
        Me.NOMBRETextBox.Location = New System.Drawing.Point(134, 128)
        Me.NOMBRETextBox.Name = "NOMBRETextBox"
        Me.NOMBRETextBox.Size = New System.Drawing.Size(121, 20)
        Me.NOMBRETextBox.TabIndex = 5
        '
        'IDEPTOPComboBox
        '
        Me.IDEPTOPComboBox.FormattingEnabled = True
        Me.IDEPTOPComboBox.Location = New System.Drawing.Point(135, 63)
        Me.IDEPTOPComboBox.Name = "IDEPTOPComboBox"
        Me.IDEPTOPComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IDEPTOPComboBox.TabIndex = 3
        '
        'IDPUESTOComboBox
        '
        Me.IDPUESTOComboBox.FormattingEnabled = True
        Me.IDPUESTOComboBox.Location = New System.Drawing.Point(134, 95)
        Me.IDPUESTOComboBox.Name = "IDPUESTOComboBox"
        Me.IDPUESTOComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IDPUESTOComboBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.btUPDATE)
        Me.TabPage2.Controls.Add(Me.EMPLEADODataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(943, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EDITAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btUPDATE
        '
        Me.btUPDATE.Location = New System.Drawing.Point(766, 6)
        Me.btUPDATE.Name = "btUPDATE"
        Me.btUPDATE.Size = New System.Drawing.Size(162, 30)
        Me.btUPDATE.TabIndex = 2
        Me.btUPDATE.Text = "GUARDAR CAMBIOS"
        Me.btUPDATE.UseVisualStyleBackColor = True
        '
        'EMPLEADODataGridView
        '
        Me.EMPLEADODataGridView.AutoGenerateColumns = False
        Me.EMPLEADODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPLEADODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EMPLEADODataGridView.DataSource = Me.EMPLEADOBindingSource
        Me.EMPLEADODataGridView.Location = New System.Drawing.Point(6, 42)
        Me.EMPLEADODataGridView.Name = "EMPLEADODataGridView"
        Me.EMPLEADODataGridView.Size = New System.Drawing.Size(929, 326)
        Me.EMPLEADODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDEMPLEADO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "APELLIDO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "APELLIDO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DPI"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DPI"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "USUARIO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "USUARIO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CONTRASENA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CONTRASENA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'EMPLEADOBindingSource
        '
        Me.EMPLEADOBindingSource.DataMember = "EMPLEADO"
        Me.EMPLEADOBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOTableAdapter
        '
        Me.EMPLEADOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CUENTATableAdapter = Nothing
        Me.TableAdapterManager.DEPARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.EMPLEADOTableAdapter = Me.EMPLEADOTableAdapter
        Me.TableAdapterManager.PUESTOTableAdapter = Nothing
        Me.TableAdapterManager.TARJETATableAdapter = Nothing
        Me.TableAdapterManager.TIPOCUENTATableAdapter = Nothing
        Me.TableAdapterManager.TRANSACIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(727, 132)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(150, 175)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(150, 82)
        Me.ToolStripContainer2.Location = New System.Drawing.Point(707, 310)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(150, 107)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(951, 377)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(951, 402)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'frm_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 402)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer3)
        Me.Name = "frm_Empleados"
        Me.Text = "Empleados"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.EMPLEADODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DS As Banco.DS
    Friend WithEvents EMPLEADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLEADOTableAdapter As Banco.DSTableAdapters.EMPLEADOTableAdapter
    Friend WithEvents TableAdapterManager As Banco.DSTableAdapters.TableAdapterManager
    Friend WithEvents CONTRASENATextBox As System.Windows.Forms.TextBox
    Friend WithEvents USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DPITextBox As System.Windows.Forms.TextBox
    Friend WithEvents APELLIDOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMBRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDEPTOPComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDPUESTOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btUPDATE As System.Windows.Forms.Button
    Friend WithEvents EMPLEADODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
