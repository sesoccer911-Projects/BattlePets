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

namespace BattlePets
{
    public partial class PetTeam : Form
    {
        public PetTeam()
        {
            InitializeComponent();
        }

        private string _cnDB = BattlePets.Properties.Settings.Default.F2T5ConnectionString;

        string name;
        int i = 0;

        private void PetTeam_Load(object sender, EventArgs e)
        {
            i = AddAbilityCategory(name, _cnDB);
            petOneAbilityButton.BackgroundImage = LoadAbilityImage(i);
        }


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

        static public int AddAbilityCategory(string newName, string connString)
        {
            Int32 newProdID = 0;
            string sql = "SELECT AbilityPic FROM[dbo].[Ability] WHERE AbilityId = (select[Pet1Ability1] from [dbo].[PetTeam] where trainerid = 1)";
       
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@AbilityID", SqlDbType.Int);
                cmd.Parameters["@abilityid"].Value = newName;
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return (int)newProdID;
        }

    }
}