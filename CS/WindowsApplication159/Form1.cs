using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace WindowsApplication159
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.Design.XViews xv = new DevExpress.XtraTreeList.Design.XViews(treeList1);
            TreeListNode node = treeList1.Nodes[0].Nodes[0];
        }

        private void treeList1_AfterCheckNode(object sender, NodeEventArgs e)
        {
            UncheckSiblingNodes(e.Node);
        }

        void UncheckSiblingNodes(TreeListNode node)
        {
            TreeListNodes nodes = null;
            if (node.Level == 0)
                nodes = treeList1.Nodes;
            else
                nodes = node.ParentNode.Nodes;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] != node)
                    nodes[i].CheckState = CheckState.Unchecked;
            }
        }

        private void treeList1_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            if (e.Node.Level <= 1) e.CanCheck = false;
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        private void treeList1_CustomDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e)
        {
            if (e.Node.Level <= 1)
                e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled;
        }
    }
}