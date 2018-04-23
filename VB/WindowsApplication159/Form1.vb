Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace WindowsApplication159
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim xv As New DevExpress.XtraTreeList.Design.XViews(treeList1)
			Dim node As TreeListNode = treeList1.Nodes(0).Nodes(0)
		End Sub

		Private Sub treeList1_AfterCheckNode(ByVal sender As Object, ByVal e As NodeEventArgs) Handles treeList1.AfterCheckNode
			UncheckSiblingNodes(e.Node)
		End Sub

		Private Sub UncheckSiblingNodes(ByVal node As TreeListNode)
			Dim nodes As TreeListNodes = Nothing
			If node.Level = 0 Then
				nodes = treeList1.Nodes
			Else
				nodes = node.ParentNode.Nodes
			End If
			For i As Integer = 0 To nodes.Count - 1
				If nodes(i) IsNot node Then
					nodes(i).CheckState = CheckState.Unchecked
				End If
			Next i
		End Sub

		Private Sub treeList1_BeforeCheckNode(ByVal sender As Object, ByVal e As CheckNodeEventArgs) Handles treeList1.BeforeCheckNode
			If e.Node.Level <= 1 Then
				e.CanCheck = False
			End If
			If e.PrevState = CheckState.Checked Then
				e.State = (CheckState.Unchecked)
			Else
				e.State = (CheckState.Checked)
			End If
		End Sub

		Private Sub treeList1_CustomDrawNodeCheckBox(ByVal sender As Object, ByVal e As CustomDrawNodeCheckBoxEventArgs) Handles treeList1.CustomDrawNodeCheckBox
			If e.Node.Level <= 1 Then
				e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled
			End If
		End Sub
	End Class
End Namespace