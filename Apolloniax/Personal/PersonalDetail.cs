using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Apolloniax.Properties;

namespace Apolloniax.Personal {
    public partial class PersonalDetail : DetailControl {
        public PersonalDetail() {
            InitializeComponent();
        }

        public override string DisplayName {
            get {
                return Resources.PersonalDetailDisplayName;
            }
        }
    }
}
