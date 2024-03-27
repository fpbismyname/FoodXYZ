namespace FoodXYZ.Halaman.Admin.Page
{
    partial class LaporanPenjualan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(113, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(239, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tanggal Akhir";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(415, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2024, 3, 27, 20, 58, 40, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 27, 20, 58, 40, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 162);
            this.dataGridView1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 306);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(472, 166);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(368, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // LaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanPenjualan";
            this.Text = "LaporanPenjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
    }
}