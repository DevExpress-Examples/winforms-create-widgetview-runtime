// Developer Express Code Central Example:
// How To: Create WidgetView at runtime
// 
// This example demonstrates how to create and customize WidgetView with 2
// StackGroups at runtime.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5003

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;

namespace WidgetViewExample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {
            AddDocumentManager();
            for (int i = 0; i < 3; i++) {
                AddDocuments();
            }
            //Adding Documents to group1 is not necessary, since all newly created Documents are automatically placed in the first StackGroup.
            group1.Items.AddRange(new Document[] { view.Documents[0] as Document, view.Documents[1] as Document });
            view.Controller.Dock(view.Documents[2] as Document, group2);
        }

        WidgetView view;
        StackGroup group1, group2;
        void AddDocumentManager() {
            DocumentManager dM = new DocumentManager(components);
            view = new WidgetView();
            dM.View = view;
            view.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            group1 = new StackGroup();
            group2 = new StackGroup();
            group1.Length.UnitType = LengthUnitType.Star;
            group1.Length.UnitValue = 2;
            view.StackGroups.AddRange(new StackGroup[] { group1, group2 });
            dM.ContainerControl = this;
        }

        int count = 1;
        void AddDocuments() {
            Document document = view.AddDocument(new ucPreview()) as Document;
            document.MaximizedControl = new ucMaximizedContent();
            count++;
        }
    }
}
