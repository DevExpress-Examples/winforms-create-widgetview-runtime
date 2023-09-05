' Developer Express Code Central Example:
' How To: Create WidgetView at runtime
' 
' This example demonstrates how to create and customize WidgetView with 2
' StackGroups at runtime.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5003
Imports System
Imports System.Windows.Forms

Namespace WidgetViewExample

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
