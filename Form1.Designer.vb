<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnUpdateCost = New System.Windows.Forms.Button()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.btnSpecificItem = New System.Windows.Forms.Button()
        Me.btnSearchOverCost = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lblProgrammedBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(42, 34)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(113, 25)
        Me.lblFood.TabIndex = 0
        Me.lblFood.Text = "Food Item:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(93, 92)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(62, 25)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost:"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(176, 34)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(270, 31)
        Me.txtFood.TabIndex = 2
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(176, 86)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(270, 31)
        Me.txtCost.TabIndex = 3
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(505, 34)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(163, 83)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(701, 34)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(162, 83)
        Me.btnDeleteItem.TabIndex = 5
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnUpdateCost
        '
        Me.btnUpdateCost.Location = New System.Drawing.Point(887, 34)
        Me.btnUpdateCost.Name = "btnUpdateCost"
        Me.btnUpdateCost.Size = New System.Drawing.Size(188, 83)
        Me.btnUpdateCost.TabIndex = 6
        Me.btnUpdateCost.Text = "Update Cost"
        Me.btnUpdateCost.UseVisualStyleBackColor = True
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Location = New System.Drawing.Point(47, 182)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(193, 76)
        Me.btnDisplayAll.TabIndex = 7
        Me.btnDisplayAll.Text = "Display All Items"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'btnSpecificItem
        '
        Me.btnSpecificItem.Location = New System.Drawing.Point(266, 182)
        Me.btnSpecificItem.Name = "btnSpecificItem"
        Me.btnSpecificItem.Size = New System.Drawing.Size(180, 76)
        Me.btnSpecificItem.TabIndex = 8
        Me.btnSpecificItem.Text = "Search For Specific Item"
        Me.btnSpecificItem.UseVisualStyleBackColor = True
        '
        'btnSearchOverCost
        '
        Me.btnSearchOverCost.Location = New System.Drawing.Point(472, 182)
        Me.btnSearchOverCost.Name = "btnSearchOverCost"
        Me.btnSearchOverCost.Size = New System.Drawing.Size(196, 76)
        Me.btnSearchOverCost.TabIndex = 9
        Me.btnSearchOverCost.Text = "Search for Items Over Given Cost"
        Me.btnSearchOverCost.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(704, 182)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(159, 76)
        Me.btnClearForm.TabIndex = 10
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(910, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 76)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 25
        Me.lstDisplay.Location = New System.Drawing.Point(47, 332)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(621, 304)
        Me.lstDisplay.TabIndex = 12
        '
        'lblProgrammedBy
        '
        Me.lblProgrammedBy.AutoSize = True
        Me.lblProgrammedBy.Location = New System.Drawing.Point(42, 697)
        Me.lblProgrammedBy.Name = "lblProgrammedBy"
        Me.lblProgrammedBy.Size = New System.Drawing.Size(295, 25)
        Me.lblProgrammedBy.TabIndex = 13
        Me.lblProgrammedBy.Text = "Programmed By: Adarion Ray"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1385, 773)
        Me.Controls.Add(Me.lblProgrammedBy)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnSearchOverCost)
        Me.Controls.Add(Me.btnSpecificItem)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Controls.Add(Me.btnUpdateCost)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblFood)
        Me.Name = "Form1"
        Me.Text = "Holiday Foods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFood As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtFood As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnUpdateCost As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnSpecificItem As Button
    Friend WithEvents btnSearchOverCost As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents lblProgrammedBy As Label
End Class
