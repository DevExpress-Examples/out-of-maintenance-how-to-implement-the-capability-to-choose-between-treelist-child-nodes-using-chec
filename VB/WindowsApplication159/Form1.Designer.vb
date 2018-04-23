Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication159
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AllowIndeterminateCheckState = True
			Me.treeList1.OptionsView.ShowCheckBoxes = True
			Me.treeList1.Size = New System.Drawing.Size(665, 418)
			Me.treeList1.TabIndex = 8
'			Me.treeList1.BeforeCheckNode += New DevExpress.XtraTreeList.CheckNodeEventHandler(Me.treeList1_BeforeCheckNode);
'			Me.treeList1.CustomDrawNodeCheckBox += New DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(Me.treeList1_CustomDrawNodeCheckBox);
'			Me.treeList1.AfterCheckNode += New DevExpress.XtraTreeList.NodeEventHandler(Me.treeList1_AfterCheckNode);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(665, 418)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList

	End Class
End Namespace

