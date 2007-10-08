using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Apolloniax {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            detailControls = new Collection<DetailControl>();

            Collection<Type> detailTypes = DetailControlTypes.ListTypes();
            foreach (Type type in detailTypes) {
                DetailControl detailControl = (DetailControl)Activator.CreateInstance(type);
                this.Controls.Add(detailControl);
                this.DetailControls.Add(detailControl);
                detailControl.Dock = DockStyle.Fill;
                detailControl.BringToFront();

                ToolStripMenuItem menuItem = new ToolStripMenuItem(detailControl.DisplayName);
                menuItem.Click += delegate {
                    detailControl.BringToFront();
                };

                detailMenu.DropDownItems.Add(menuItem);
            }
        }

        private Collection<DetailControl> detailControls;
        public Collection<DetailControl> DetailControls {
            get { return detailControls; }
        }

        private void menuClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}