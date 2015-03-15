<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.colFruitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFruitColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFruitIsYummy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFruitName, Me.colFruitColor, Me.colFruitIsYummy})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 154)
        Me.DataGridView1.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(24, 192)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(439, 23)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "SaveChanges()"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUpdate.Location = New System.Drawing.Point(20, 227)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(166, 20)
        Me.lblUpdate.TabIndex = 3
        Me.lblUpdate.Text = "Update Successful!"
        Me.lblUpdate.Visible = False
        '
        'colFruitName
        '
        Me.colFruitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFruitName.DataPropertyName = "FruitName"
        Me.colFruitName.HeaderText = "Fruit Name"
        Me.colFruitName.Name = "colFruitName"
        '
        'colFruitColor
        '
        Me.colFruitColor.DataPropertyName = "FruitColor"
        Me.colFruitColor.HeaderText = "Color"
        Me.colFruitColor.Name = "colFruitColor"
        '
        'colFruitIsYummy
        '
        Me.colFruitIsYummy.DataPropertyName = "FruitIsYummy"
        Me.colFruitIsYummy.HeaderText = "Is Yummy?"
        Me.colFruitIsYummy.Name = "colFruitIsYummy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 265)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "EF 6 Code First DataGridView binding example"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents colFruitName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFruitColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFruitIsYummy As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
