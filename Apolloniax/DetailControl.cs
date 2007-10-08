using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;
using Apolloniax.Properties;

namespace Apolloniax {
    public partial class DetailControl : UserControl {
        public DetailControl() {
            InitializeComponent();
        }

        private Patient patient;

        /// <summary>
        /// Gets or sets the <see cref="Patient"/> currently displayed.
        /// </summary>
        public Patient Patient {
            get { return patient; }
            set { patient = value; }
        }

        public virtual string DisplayName {
            get { return Resources.DefaultDisplayName; }
        }
    }
}
