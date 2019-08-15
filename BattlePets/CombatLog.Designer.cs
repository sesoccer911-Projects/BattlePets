namespace BattlePets
{
    partial class CombatLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.f2T5DataSet = new BattlePets.F2T5DataSet();
            this.combat_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combat_LogTableAdapter = new BattlePets.F2T5DataSetTableAdapters.Combat_LogTableAdapter();
            this.tableAdapterManager = new BattlePets.F2T5DataSetTableAdapters.TableAdapterManager();
            this.combat_LogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.f2T5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combat_LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combat_LogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // f2T5DataSet
            // 
            this.f2T5DataSet.DataSetName = "F2T5DataSet";
            this.f2T5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combat_LogBindingSource
            // 
            this.combat_LogBindingSource.DataMember = "Combat_Log";
            this.combat_LogBindingSource.DataSource = this.f2T5DataSet;
            // 
            // combat_LogTableAdapter
            // 
            this.combat_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbilityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Combat_LogTableAdapter = this.combat_LogTableAdapter;
            this.tableAdapterManager.PetStorageTableAdapter = null;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.PetTeamTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BattlePets.F2T5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combat_LogDataGridView
            // 
            this.combat_LogDataGridView.AllowUserToAddRows = false;
            this.combat_LogDataGridView.AllowUserToDeleteRows = false;
            this.combat_LogDataGridView.AutoGenerateColumns = false;
            this.combat_LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combat_LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.combat_LogDataGridView.DataSource = this.combat_LogBindingSource;
            this.combat_LogDataGridView.Location = new System.Drawing.Point(12, 12);
            this.combat_LogDataGridView.Name = "combat_LogDataGridView";
            this.combat_LogDataGridView.ReadOnly = true;
            this.combat_LogDataGridView.RowTemplate.Height = 24;
            this.combat_LogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.combat_LogDataGridView.Size = new System.Drawing.Size(544, 239);
            this.combat_LogDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn1.HeaderText = "Result";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EventID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EventID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PetID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PetID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TrainerID";
            this.dataGridViewTextBoxColumn5.HeaderText = "TrainerID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // CombatLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 258);
            this.Controls.Add(this.combat_LogDataGridView);
            this.Name = "CombatLog";
            this.Text = "CombatLog";
            this.Load += new System.EventHandler(this.CombatLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f2T5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combat_LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combat_LogDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private F2T5DataSet f2T5DataSet;
        private System.Windows.Forms.BindingSource combat_LogBindingSource;
        private F2T5DataSetTableAdapters.Combat_LogTableAdapter combat_LogTableAdapter;
        private F2T5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView combat_LogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}