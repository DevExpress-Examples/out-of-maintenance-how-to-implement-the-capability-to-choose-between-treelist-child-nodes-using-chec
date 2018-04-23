# How to implement the capability to choose between TreeList child nodes using checkboxes


<p>First, it's necessary to set the TreeList.OptionsView.ShowCheckBoxes property to True. Then, you should handle the BeforeCheckNode event to update the node checked state and the AfterCheckNode event to update the states of sibling nodes. The CustomDrawNodeCheckBox event is used to draw unavailable nodes grayed out.</p>

<br/>


