namespace Mispisit_test
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.main_dbDataSet = new Mispisit_test.Main_dbDataSet();
            this.protocolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.protocolTableAdapter = new Mispisit_test.Main_dbDataSetTableAdapters.ProtocolTableAdapter();
            this.tableAdapterManager = new Mispisit_test.Main_dbDataSetTableAdapters.TableAdapterManager();
            this.protocolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_SB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protocolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_dbDataSet
            // 
            this.main_dbDataSet.DataSetName = "Main_dbDataSet";
            this.main_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // protocolBindingSource
            // 
            this.protocolBindingSource.DataMember = "Protocol";
            this.protocolBindingSource.DataSource = this.main_dbDataSet;
            // 
            // protocolTableAdapter
            // 
            this.protocolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProtocolTableAdapter = this.protocolTableAdapter;
            this.tableAdapterManager.QuestionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mispisit_test.Main_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // protocolDataGridView
            // 
            this.protocolDataGridView.AllowUserToAddRows = false;
            this.protocolDataGridView.AllowUserToDeleteRows = false;
            this.protocolDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.protocolDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.protocolDataGridView.AutoGenerateColumns = false;
            this.protocolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.protocolDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.protocolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.protocolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.protocolDataGridView.DataSource = this.protocolBindingSource;
            this.protocolDataGridView.Location = new System.Drawing.Point(0, 0);
            this.protocolDataGridView.Name = "protocolDataGridView";
            this.protocolDataGridView.ReadOnly = true;
            this.protocolDataGridView.RowHeadersVisible = false;
            this.protocolDataGridView.RowHeadersWidth = 51;
            this.protocolDataGridView.RowTemplate.Height = 24;
            this.protocolDataGridView.Size = new System.Drawing.Size(262, 244);
            this.protocolDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "secName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn2.HeaderText = "Баллы";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.protocolBindingSource;
            legend1.Enabled = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(259, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "secName";
            series1.YValueMembers = "Score";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(713, 448);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label_SB
            // 
            this.label_SB.AutoSize = true;
            this.label_SB.Location = new System.Drawing.Point(11, 272);
            this.label_SB.Name = "label_SB";
            this.label_SB.Size = new System.Drawing.Size(46, 17);
            this.label_SB.TabIndex = 3;
            this.label_SB.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Гистограмма распределения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_SB);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.protocolDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protocolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Main_dbDataSet main_dbDataSet;
        private System.Windows.Forms.BindingSource protocolBindingSource;
        private Main_dbDataSetTableAdapters.ProtocolTableAdapter protocolTableAdapter;
        private Main_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView protocolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_SB;
        private System.Windows.Forms.Button button1;
    }
}