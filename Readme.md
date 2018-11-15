<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication159/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication159/Form1.vb))
* [Program.cs](./CS/WindowsApplication159/Program.cs) (VB: [Program.vb](./VB/WindowsApplication159/Program.vb))
<!-- default file list end -->
# How to implement the capability to choose between TreeList child nodes using checkboxes


<p>First, it's necessary to set the TreeList.OptionsView.ShowCheckBoxes property to True. Then, you should handle the BeforeCheckNode event to update the node checked state and the AfterCheckNode event to update the states of sibling nodes. The CustomDrawNodeCheckBox event is used to draw unavailable nodes grayed out.</p>

<br/>


