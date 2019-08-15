using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattlePets
{
    public partial class CombatLog : Form
    {
        public CombatLog()
        {
            InitializeComponent();
        }

        private void combat_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combat_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f2T5DataSet);

        }

        private void CombatLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f2T5DataSet.Combat_Log' table. You can move, or remove it, as needed.
            this.combat_LogTableAdapter.Fill(this.f2T5DataSet.Combat_Log);

        }
    }
}
