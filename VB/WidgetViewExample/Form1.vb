' Developer Express Code Central Example:
' How To: Create WidgetView at runtime
' 
' This example demonstrates how to create and customize WidgetView with 2
' StackGroups at runtime.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5003
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Widget
Imports DevExpress.XtraEditors

Namespace WidgetViewExample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddDocumentManager()
            For i As Integer = 0 To 3 - 1
                AddDocuments()
            Next

            'Adding Documents to group1 is not necessary, since all newly created Documents are automatically placed in the first StackGroup.
            group1.Items.AddRange(New Document() {TryCast(view.Documents(0), Document), TryCast(view.Documents(1), Document)})
            view.Controller.Dock(TryCast(view.Documents(2), Document), group2)
        End Sub

        Private view As WidgetView

        Private group1, group2 As StackGroup

        Private Sub AddDocumentManager()
            Dim dM As DocumentManager = New DocumentManager(components)
            view = New WidgetView()
            dM.View = view
            view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True
            group1 = New StackGroup()
            group2 = New StackGroup()
            group1.Length.UnitType = LengthUnitType.Star
            group1.Length.UnitValue = 2
            view.StackGroups.AddRange(New StackGroup() {group1, group2})
            dM.ContainerControl = Me
        End Sub

        Private count As Integer = 1

        Private Sub AddDocuments()
            Dim document As Document = TryCast(view.AddDocument(New ucPreview()), Document)
            document.MaximizedControl = New ucMaximizedContent()
            count += 1
        End Sub
    End Class
End Namespace
