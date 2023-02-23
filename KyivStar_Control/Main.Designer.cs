namespace KyivStar_Control
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.table_tariff = new System.Windows.Forms.TableLayoutPanel();
            this.bn_aboutTariff = new System.Windows.Forms.Button();
            this.ibi_Tarif_inf = new System.Windows.Forms.Label();
            this.table_balances = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_internet = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.lbl_mms = new System.Windows.Forms.Label();
            this.lbl_callKyivstar = new System.Windows.Forms.Label();
            this.lbl_callOther = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.table_Main.SuspendLayout();
            this.table_tariff.SuspendLayout();
            this.table_balances.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_Main
            // 
            this.table_Main.ColumnCount = 1;
            this.table_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table_Main.Controls.Add(this.lbl_title, 0, 0);
            this.table_Main.Controls.Add(this.table_tariff, 0, 1);
            this.table_Main.Controls.Add(this.table_balances, 0, 3);
            this.table_Main.Controls.Add(this.lbl_balance, 0, 2);
            this.table_Main.Location = new System.Drawing.Point(0, 0);
            this.table_Main.Margin = new System.Windows.Forms.Padding(5);
            this.table_Main.Name = "table_Main";
            this.table_Main.RowCount = 4;
            this.table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.25F));
            this.table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.75F));
            this.table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.table_Main.Size = new System.Drawing.Size(933, 309);
            this.table_Main.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Location = new System.Drawing.Point(5, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(923, 41);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Огляд";
            // 
            // table_tariff
            // 
            this.table_tariff.ColumnCount = 2;
            this.table_tariff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_tariff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_tariff.Controls.Add(this.bn_aboutTariff, 1, 0);
            this.table_tariff.Controls.Add(this.ibi_Tarif_inf, 0, 0);
            this.table_tariff.Dock = System.Windows.Forms.DockStyle.Left;
            this.table_tariff.Location = new System.Drawing.Point(5, 46);
            this.table_tariff.Margin = new System.Windows.Forms.Padding(5);
            this.table_tariff.Name = "table_tariff";
            this.table_tariff.RowCount = 1;
            this.table_tariff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_tariff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.table_tariff.Size = new System.Drawing.Size(440, 62);
            this.table_tariff.TabIndex = 1;
            // 
            // bn_aboutTariff
            // 
            this.bn_aboutTariff.Location = new System.Drawing.Point(225, 5);
            this.bn_aboutTariff.Margin = new System.Windows.Forms.Padding(5);
            this.bn_aboutTariff.Name = "bn_aboutTariff";
            this.bn_aboutTariff.Size = new System.Drawing.Size(118, 38);
            this.bn_aboutTariff.TabIndex = 2;
            this.bn_aboutTariff.Text = "Про тариф";
            this.bn_aboutTariff.UseVisualStyleBackColor = true;
            this.bn_aboutTariff.Click += new System.EventHandler(this.bn_aboutTariff_Click);
            // 
            // ibi_Tarif_inf
            // 
            this.ibi_Tarif_inf.AutoSize = true;
            this.ibi_Tarif_inf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibi_Tarif_inf.Location = new System.Drawing.Point(5, 0);
            this.ibi_Tarif_inf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ibi_Tarif_inf.Name = "ibi_Tarif_inf";
            this.ibi_Tarif_inf.Size = new System.Drawing.Size(210, 62);
            this.ibi_Tarif_inf.TabIndex = 1;
            this.ibi_Tarif_inf.Text = "Тариф: Твій Новий";
            // 
            // table_balances
            // 
            this.table_balances.ColumnCount = 5;
            this.table_balances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_balances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_balances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.table_balances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.table_balances.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.table_balances.Controls.Add(this.label5, 4, 1);
            this.table_balances.Controls.Add(this.label4, 3, 1);
            this.table_balances.Controls.Add(this.label3, 2, 1);
            this.table_balances.Controls.Add(this.label2, 1, 1);
            this.table_balances.Controls.Add(this.label1, 0, 1);
            this.table_balances.Controls.Add(this.lbl_internet, 0, 0);
            this.table_balances.Controls.Add(this.lbl_sms, 1, 0);
            this.table_balances.Controls.Add(this.lbl_mms, 2, 0);
            this.table_balances.Controls.Add(this.lbl_callKyivstar, 3, 0);
            this.table_balances.Controls.Add(this.lbl_callOther, 4, 0);
            this.table_balances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_balances.Location = new System.Drawing.Point(5, 169);
            this.table_balances.Margin = new System.Windows.Forms.Padding(5);
            this.table_balances.Name = "table_balances";
            this.table_balances.RowCount = 2;
            this.table_balances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_balances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.table_balances.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.table_balances.Size = new System.Drawing.Size(923, 135);
            this.table_balances.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(685, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 58);
            this.label5.TabIndex = 9;
            this.label5.Text = "500 хв";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(469, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Безліміт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(311, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 58);
            this.label3.TabIndex = 7;
            this.label3.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(157, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "2,4 гб";
            // 
            // lbl_internet
            // 
            this.lbl_internet.AutoSize = true;
            this.lbl_internet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_internet.Location = new System.Drawing.Point(3, 0);
            this.lbl_internet.Name = "lbl_internet";
            this.lbl_internet.Size = new System.Drawing.Size(148, 77);
            this.lbl_internet.TabIndex = 0;
            this.lbl_internet.Text = "Інтернет";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sms.Location = new System.Drawing.Point(157, 0);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(148, 77);
            this.lbl_sms.TabIndex = 1;
            this.lbl_sms.Text = "СМС";
            // 
            // lbl_mms
            // 
            this.lbl_mms.AutoSize = true;
            this.lbl_mms.Location = new System.Drawing.Point(311, 0);
            this.lbl_mms.Name = "lbl_mms";
            this.lbl_mms.Size = new System.Drawing.Size(58, 25);
            this.lbl_mms.TabIndex = 2;
            this.lbl_mms.Text = "ММС";
            // 
            // lbl_callKyivstar
            // 
            this.lbl_callKyivstar.AutoSize = true;
            this.lbl_callKyivstar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_callKyivstar.Location = new System.Drawing.Point(469, 0);
            this.lbl_callKyivstar.Name = "lbl_callKyivstar";
            this.lbl_callKyivstar.Size = new System.Drawing.Size(210, 77);
            this.lbl_callKyivstar.TabIndex = 3;
            this.lbl_callKyivstar.Text = "Дзвінки на Київстар";
            // 
            // lbl_callOther
            // 
            this.lbl_callOther.AutoSize = true;
            this.lbl_callOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_callOther.Location = new System.Drawing.Point(685, 0);
            this.lbl_callOther.Name = "lbl_callOther";
            this.lbl_callOther.Size = new System.Drawing.Size(235, 77);
            this.lbl_callOther.TabIndex = 4;
            this.lbl_callOther.Text = "Дзвінки на інші мережі";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_balance.Location = new System.Drawing.Point(5, 113);
            this.lbl_balance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(923, 51);
            this.lbl_balance.TabIndex = 3;
            this.lbl_balance.Text = "Залишки";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(965, 350);
            this.table_Main.ResumeLayout(false);
            this.table_Main.PerformLayout();
            this.table_tariff.ResumeLayout(false);
            this.table_tariff.PerformLayout();
            this.table_balances.ResumeLayout(false);
            this.table_balances.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel table_Main;
        private Label lbl_title;
        private TableLayoutPanel table_tariff;
        private Button bn_aboutTariff;
        private Label ibi_Tarif_inf;
        private TableLayoutPanel table_balances;
        private Label lbl_balance;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_internet;
        private Label lbl_sms;
        private Label lbl_mms;
        private Label lbl_callKyivstar;
        private Label lbl_callOther;
    }
}