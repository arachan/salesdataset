<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.arvMain = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.SuspendLayout()
        '
        'arvMain
        '
        Me.arvMain.CurrentPage = 0
        resources.ApplyResources(Me.arvMain, "arvMain")
        Me.arvMain.Name = "arvMain"
        Me.arvMain.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.arvMain.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.arvMain.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.arvMain.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.ThumbnailsPanel.Width = 200
        Me.arvMain.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.arvMain.Sidebar.TocPanel.ContextMenu = Nothing
        Me.arvMain.Sidebar.TocPanel.Expanded = True
        Me.arvMain.Sidebar.TocPanel.Width = 200
        Me.arvMain.Sidebar.Width = 200
        '
        'ViewerForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.arvMain)
        Me.Name = "ViewerForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents arvMain As GrapeCity.ActiveReports.Viewer.Win.Viewer
End Class
