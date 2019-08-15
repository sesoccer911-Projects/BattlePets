using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BattlePets
{
    public partial class PetJournal : Form
    {


        public PetJournal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpbxAbility1_Enter(object sender, EventArgs e)
        {

        }

        private void lblFavorite_Click(object sender, EventArgs e)
        {

        }

        private void PetJournal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f2T5DataSet.usp_getPartyDetails' table. You can move, or remove it, as needed.
            this.usp_getPartyDetailsTableAdapter.Fill(this.f2T5DataSet.usp_getPartyDetails);
            // TODO: This line of code loads data into the 'f2T5DataSet1.PetTeam' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'f2T5DataSet.usp_getJournalDetails' table. You can move, or remove it, as needed.

            this.usp_getJournalDetailsTableAdapter.Fill(this.f2T5DataSet.usp_getJournalDetails);
            // TODO: This line of code loads data into the 'f2T5DataSet.PetStorage' table. You can move, or remove it, as needed.
            this.petStorageTableAdapter.Fill(this.f2T5DataSet.PetStorage);
            // TODO: This line of code loads data into the 'f2T5DataSet.PetTeam' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'f2T5DataSet.Pet' table. You can move, or remove it, as needed.
            f2T5DataSet.EnforceConstraints = false;
            this.petTableAdapter.Fill(f2T5DataSet.Pet);


            /*if (System.DBNull.Value != dgvPartySlots.SelectedRows[0].Cells["PetPic"].Value)
            {
                byte[] imgData = (byte[])dgvPartySlots.SelectedRows[0].Cells["PetPic"].Value;
                MemoryStream ms = new MemoryStream(imgData);
                pbImage.Image = Image.FromStream(ms);
            }
            else
            {
                pbImage.Image = null;
            }*/

        }

        private void petDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //lblName.Text = petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            //MessageBox.Show(petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            //lblName.Text = (string)petDataGridView[petDataGridView.CurrentRow.Index, 0].Value;
            //lblLevel.Text = (string)petDataGridView[petDataGridView.CurrentRow.Index, 4].Value;
        }


        private void btnPetInfo_Click(object sender, EventArgs e)
        {
            //           BattlePet temp = new BattlePet((string)(dgvPartySlots.SelectedRows[0].Cells[1].Value), (int)dgvPartySlots.SelectedRows[0].Cells[18].Value, dgvPartySlots.SelectedRows[0].Cells[3].Value, dgvPartySlots.SelectedRows[0].Cells[19].Value, dgvPartySlots.SelectedRows[0].Cells[0].Value, dgvPartySlots.SelectedRows[0].Cells[2].Value, dgvPartySlots.SelectedRows[0].Cells[4].Value, dgvPartySlots.SelectedRows[0].Cells[5].Value, dgvPartySlots.SelectedRows[0].Cells[6].Value, dgvPartySlots.SelectedRows[0].Cells[7].Value, dgvPartySlots.SelectedRows[0].Cells[8].Value, dgvPartySlots.SelectedRows[0].Cells[16].Value, BattlePet.BattlePetType enum Critter);
            PetInfo info = new PetInfo();           //create a new PetInfo instance
            BattlePet p = (BattlePet)info.Tag; // using the instance to tag to the petinfo frm
            info.ShowDialog(this);
        }

        private void btnAddtoParty_Click(object sender, EventArgs e)
        {
            /*battlepet = new List<BattlePet>();
            if (List<BattlePet>(battlepet.Count) >= 3)
            {
                //error for having more than 3 pets in a party
            }
            else
            {
                petDex.Add((BattlePet)selected.Clone()); // clone the selected pet in the petjournal
            }
            dgvPartySlots.DataSource = typeof(BattlePet); // refresh the  stuff
            dgvPartySlots.DataSource = battlepet;
            dgvPartySlots.Refresh();
            petDex.Add((BattlePet)selected.Clone());*/
        }

        private void btnClearParty_Click(object sender, EventArgs e)
        {
            //battlepet.clear(); // clear the party
            //dgvPartySlots.Refresh();
        }

        private void petDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void dgvPartySlots_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPartySlots.SelectedRows.Count > 0)
            {
                string partyPetType;
                int healthValue = 0, healthValueMax = 0;
                lblName.Text = dgvPartySlots.SelectedRows[0].Cells[1].Value.ToString();
                lblLevel.Text = dgvPartySlots.SelectedRows[0].Cells[2].Value.ToString();
                partyPetType = dgvPartySlots.SelectedRows[0].Cells[2].Value.ToString();

                btnAbility1Sel1.Enabled = true;
                btnAbility1Sel2.Enabled = true;
                btnAbility2Sel1.Enabled = true;
                btnAbility2Sel2.Enabled = true;
                btnAbility3Sel1.Enabled = true;
                btnAbility3Sel2.Enabled = true;
                pbSelAbility.Image = null;
                lblAbilityNameText.Text = null;
                lblTypeText.Text = null;
                txtbxAbilityDesc.Text = null;
                //switch on assigning pet type
                switch (partyPetType)
                {
                    case ("0"):
                        {
                            partyPetType = "Aquatic";
                            break;
                        }
                    case ("1"):
                        {
                            partyPetType = "Beast";
                            break;
                        }
                    case ("2"):
                        {
                            partyPetType = "Critter";
                            break;
                        }
                    case ("3"):
                        {
                            partyPetType = "Dragonkin";
                            break;
                        }
                    case ("4"):
                        {
                            partyPetType = "Elemental";
                            break;
                        }
                    case ("5"):
                        {
                            partyPetType = "Flying";
                            break;
                        }
                    case ("6"):
                        {
                            partyPetType = "Humanoid";
                            break;
                        }
                    case ("7"):
                        {
                            partyPetType = "Magic";
                            break;
                        }
                    case ("8"):
                        {
                            partyPetType = "Mechanical";
                            break;
                        }
                    case ("9"):
                        {
                            partyPetType = "Undead";
                            break;
                        }
                }

                lblType.Text = partyPetType;
                lblRarity.Text = dgvPartySlots.SelectedRows[0].Cells[8].Value.ToString();
                lblHealth.Text = dgvPartySlots.SelectedRows[0].Cells[4].Value.ToString();
                lblSpeed.Text = dgvPartySlots.SelectedRows[0].Cells[7].Value.ToString();
                lblPower.Text = dgvPartySlots.SelectedRows[0].Cells[6].Value.ToString();
                healthValueMax = Convert.ToInt32(dgvPartySlots.SelectedRows[0].Cells[5].Value.ToString());
                pgBarHealth.Maximum = healthValueMax;
                healthValue = Convert.ToInt32(dgvPartySlots.SelectedRows[0].Cells[4].Value.ToString());
                pgBarHealth.Value = healthValue;
                Image img = (Bitmap)((new ImageConverter().ConvertFrom(dgvPartySlots.SelectedRows[0].Cells[20].Value)));
                pbImage.Image = img;
                // lblName.Text = petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString(); //debug
                // MessageBox.Show(petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
                int abilityId;
                try
                {
                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability1s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility1Sel1.Image = LoadAbilityImage(abilityId);

                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability1s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility1Sel2.Image = LoadAbilityImage(abilityId);

                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability2s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility2Sel1.Image = LoadAbilityImage(abilityId);

                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability2s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility2Sel2.Image = LoadAbilityImage(abilityId);

                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability3s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility3Sel1.Image = LoadAbilityImage(abilityId);

                    int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability3s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
                    btnAbility3Sel2.Image = LoadAbilityImage(abilityId);
                }
                catch (Exception ex)
                {
                }

            }
        }

        private string _cnDB = BattlePets.Properties.Settings.Default.F2T5ConnectionString;

        private Image LoadAbilityImage(int abilityId)
        {
            Image img = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT AbilityPic FROM dbo.Ability WHERE AbilityId = @AbilityId", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityId", SqlDbType.Int).Value = abilityId;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            MemoryStream ms = new MemoryStream((byte[])result);
                            img = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            return img;
        }
        private string LoadAbilityName(int abilityId)
        {
            string name = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT AbilityName FROM dbo.Ability WHERE AbilityId = @AbilityId", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityId", SqlDbType.Int).Value = abilityId;
                        cn.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != System.DBNull.Value)
                        {
                            name = result.ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            return name;
        }

        private string LoadAbilityType(int abilityId)
        {
            string type = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TypeName FROM dbo.Ability WHERE AbilityId = @AbilityId", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityId", SqlDbType.Int).Value = abilityId;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            type = result.ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            return type;
        }
        private string LoadAbilityDes(int abilityId)
        {
            string des = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Description FROM dbo.Ability WHERE AbilityId = @AbilityId", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityId", SqlDbType.Int).Value = abilityId;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            des = result.ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            return des;
        }


        private void petDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblName.Text = petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            // MessageBox.Show(petDataGridView.Rows[petDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

        }

        private void rb1Ability3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click_1(object sender, EventArgs e)
        {

        }

        private void petDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void petDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    cmRightClickMenu.Show(this, new Point(e.X, e.Y));
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnAbility1Sel1_Click(object sender, EventArgs e)
        {
            btnAbility1Sel1.Enabled = false;
            btnAbility1Sel2.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability1s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }


        private void btnAbility1Sel2_Click(object sender, EventArgs e)
        {
            btnAbility1Sel2.Enabled = false;
            btnAbility1Sel1.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability1s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }

        private void btnAbility2Sel1_Click(object sender, EventArgs e)
        {
            btnAbility2Sel1.Enabled = false;
            btnAbility2Sel2.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability2s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }

        private void btnAbility2Sel2_Click(object sender, EventArgs e)
        {
            btnAbility2Sel2.Enabled = false;
            btnAbility2Sel1.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability2s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }

        private void btnAbility3Sel1_Click(object sender, EventArgs e)
        {
            btnAbility3Sel1.Enabled = false;
            btnAbility3Sel2.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability3s1DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }

        private void btnAbility3Sel2_Click(object sender, EventArgs e)
        {
            btnAbility3Sel2.Enabled = false;
            btnAbility3Sel1.Enabled = true;

            int abilityId;
            int.TryParse(dgvPartySlots.SelectedRows[0].Cells["ability3s2DataGridViewTextBoxColumn1"].Value.ToString(), out abilityId);
            pbSelAbility.Image = LoadAbilityImage(abilityId);
            lblAbilityNameText.Text = LoadAbilityName(abilityId);
            lblTypeText.Text = LoadAbilityType(abilityId);
            txtbxAbilityDesc.Text = LoadAbilityDes(abilityId);
        }

        private void btnAquatic_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Aquatic";
                if (!s.StartsWith(btnAquatic.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = null;
                if (s != "dont equal me")
                {
                    row.Visible = true;
                }
                else
                    row.Visible = true;
            }
        }

        private void btnBeast_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Beast";
                if (s != btnBeast.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnCritter_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Critter";
                if (s != btnCritter.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnDragonkin_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Dragonkin";
                if (s != btnDragonkin.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnElemental_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Elemental";
                if (s != btnElemental.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnFlying_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Flying";
                if (s != btnFlying.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnHumanoid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Humanoid";
                if (s != btnHumanoid.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Magic";
                if (s != btnMagic.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnMechanical_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Mechanical";
                if (s != btnMechanical.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnUndead_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in petDataGridView.Rows)
            {
                string s = "Undead";
                if (s != btnUndead.Text)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[petDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void btnAddtoParty_Click_1(object sender, EventArgs e)
        {
            if (dgvPartySlots.RowCount >= 3)
            {

            }
            else
            {
                for (int i = dgvPartySlots.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dgvPartySlots.Rows[i];
                    if (Convert.ToBoolean(row.Cells["colLeftSelected"].Value))
                    {
                        //categoryBinding
                    }
                }
            }
        }

        private void btnRemoveFromParty_Click(object sender, EventArgs e)
        {
            for (int i = dgvPartySlots.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvPartySlots.Rows[i];
                if (Convert.ToBoolean(row.Cells["colLeftSelected"].Value))
                {
                    //categoryBinding

                }
            }
        }
    }
}
