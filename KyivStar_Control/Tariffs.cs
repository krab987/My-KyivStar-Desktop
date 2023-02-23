using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyivStar_Control
{
    public partial class Tariffs: UserControl
    {
        private Label lbl_titleTariffs;
        private TableLayoutPanel table_tariffs;
        private TableLayoutPanel table_tariffs_info;
        private Label lbl_your_new_tariff;
        private Label lbl_loveUA_tariff;
        private Label lbl_LoveUABezmezh_tariff;
        private Label lbl_LoveUaMaximum_tariff;
        private Label lbl_LoveUaNoLimit_tariff;
        private Button bn_UANolimit_connect;
        private Button bn_UAmaximum_connect;
        private Button bn_UANolimits_connect;
        private Button bn_UABaza_connect;
        private Button bn_yourNew_connect;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tariffs));
            this.lbl_titleTariffs = new System.Windows.Forms.Label();
            this.table_tariffs = new System.Windows.Forms.TableLayoutPanel();
            this.table_tariffs_info = new System.Windows.Forms.TableLayoutPanel();
            this.bn_UANolimit_connect = new System.Windows.Forms.Button();
            this.bn_UAmaximum_connect = new System.Windows.Forms.Button();
            this.bn_UANolimits_connect = new System.Windows.Forms.Button();
            this.bn_UABaza_connect = new System.Windows.Forms.Button();
            this.lbl_your_new_tariff = new System.Windows.Forms.Label();
            this.lbl_loveUA_tariff = new System.Windows.Forms.Label();
            this.lbl_LoveUABezmezh_tariff = new System.Windows.Forms.Label();
            this.lbl_LoveUaMaximum_tariff = new System.Windows.Forms.Label();
            this.lbl_LoveUaNoLimit_tariff = new System.Windows.Forms.Label();
            this.bn_yourNew_connect = new System.Windows.Forms.Button();
            this.table_tariffs.SuspendLayout();
            this.table_tariffs_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titleTariffs
            // 
            this.lbl_titleTariffs.AutoSize = true;
            this.lbl_titleTariffs.Location = new System.Drawing.Point(3, 0);
            this.lbl_titleTariffs.Name = "lbl_titleTariffs";
            this.lbl_titleTariffs.Size = new System.Drawing.Size(62, 20);
            this.lbl_titleTariffs.TabIndex = 0;
            this.lbl_titleTariffs.Text = "Тарифи";
            // 
            // table_tariffs
            // 
            this.table_tariffs.ColumnCount = 1;
            this.table_tariffs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_tariffs.Controls.Add(this.lbl_titleTariffs, 0, 0);
            this.table_tariffs.Controls.Add(this.table_tariffs_info, 0, 1);
            this.table_tariffs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.table_tariffs.Location = new System.Drawing.Point(0, 0);
            this.table_tariffs.Name = "table_tariffs";
            this.table_tariffs.RowCount = 2;
            this.table_tariffs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_tariffs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.table_tariffs.Size = new System.Drawing.Size(949, 507);
            this.table_tariffs.TabIndex = 0;
            this.table_tariffs.TabStop = true;
            this.table_tariffs.Visible = false;
            // 
            // table_tariffs_info
            // 
            this.table_tariffs_info.ColumnCount = 5;
            this.table_tariffs_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.67868F));
            this.table_tariffs_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19406F));
            this.table_tariffs_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_tariffs_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_tariffs_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_tariffs_info.Controls.Add(this.bn_UANolimit_connect, 4, 1);
            this.table_tariffs_info.Controls.Add(this.bn_UAmaximum_connect, 3, 1);
            this.table_tariffs_info.Controls.Add(this.bn_UANolimits_connect, 2, 1);
            this.table_tariffs_info.Controls.Add(this.bn_UABaza_connect, 1, 1);
            this.table_tariffs_info.Controls.Add(this.lbl_your_new_tariff, 0, 0);
            this.table_tariffs_info.Controls.Add(this.lbl_loveUA_tariff, 1, 0);
            this.table_tariffs_info.Controls.Add(this.lbl_LoveUABezmezh_tariff, 2, 0);
            this.table_tariffs_info.Controls.Add(this.lbl_LoveUaMaximum_tariff, 3, 0);
            this.table_tariffs_info.Controls.Add(this.lbl_LoveUaNoLimit_tariff, 4, 0);
            this.table_tariffs_info.Controls.Add(this.bn_yourNew_connect, 0, 1);
            this.table_tariffs_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tariffs_info.Location = new System.Drawing.Point(3, 43);
            this.table_tariffs_info.Name = "table_tariffs_info";
            this.table_tariffs_info.RowCount = 2;
            this.table_tariffs_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_tariffs_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.table_tariffs_info.Size = new System.Drawing.Size(943, 461);
            this.table_tariffs_info.TabIndex = 1;
            this.table_tariffs_info.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // bn_UANolimit_connect
            // 
            this.bn_UANolimit_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_UANolimit_connect.Location = new System.Drawing.Point(755, 391);
            this.bn_UANolimit_connect.Name = "bn_UANolimit_connect";
            this.bn_UANolimit_connect.Size = new System.Drawing.Size(185, 67);
            this.bn_UANolimit_connect.TabIndex = 11;
            this.bn_UANolimit_connect.Text = "Підключити";
            this.bn_UANolimit_connect.UseVisualStyleBackColor = true;
            // 
            // bn_UAmaximum_connect
            // 
            this.bn_UAmaximum_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_UAmaximum_connect.Location = new System.Drawing.Point(567, 391);
            this.bn_UAmaximum_connect.Name = "bn_UAmaximum_connect";
            this.bn_UAmaximum_connect.Size = new System.Drawing.Size(182, 67);
            this.bn_UAmaximum_connect.TabIndex = 10;
            this.bn_UAmaximum_connect.Text = "Підключити";
            this.bn_UAmaximum_connect.UseVisualStyleBackColor = true;
            // 
            // bn_UANolimits_connect
            // 
            this.bn_UANolimits_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_UANolimits_connect.Location = new System.Drawing.Point(379, 391);
            this.bn_UANolimits_connect.Name = "bn_UANolimits_connect";
            this.bn_UANolimits_connect.Size = new System.Drawing.Size(182, 67);
            this.bn_UANolimits_connect.TabIndex = 9;
            this.bn_UANolimits_connect.Text = "Підключити";
            this.bn_UANolimits_connect.UseVisualStyleBackColor = true;
            // 
            // bn_UABaza_connect
            // 
            this.bn_UABaza_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_UABaza_connect.Location = new System.Drawing.Point(198, 391);
            this.bn_UABaza_connect.Name = "bn_UABaza_connect";
            this.bn_UABaza_connect.Size = new System.Drawing.Size(175, 67);
            this.bn_UABaza_connect.TabIndex = 8;
            this.bn_UABaza_connect.Text = "Підключити";
            this.bn_UABaza_connect.UseVisualStyleBackColor = true;
            // 
            // lbl_your_new_tariff
            // 
            this.lbl_your_new_tariff.AutoSize = true;
            this.lbl_your_new_tariff.Location = new System.Drawing.Point(3, 0);
            this.lbl_your_new_tariff.Name = "lbl_your_new_tariff";
            this.lbl_your_new_tariff.Size = new System.Drawing.Size(180, 280);
            this.lbl_your_new_tariff.TabIndex = 3;
            this.lbl_your_new_tariff.Text = "ТВІЙ Новий\r\n\r\nМобільний зв’язок:\r\n4 ГБ мобільний інтернет\r\nБезлім дзвінки на Київ" +
    "стар\r\n60 хв дзвінки на інші мобільні по Україні\r\n\r\n19 додатків\r\nбез плати за тра" +
    "фік\r\n\r\n55 грн/4 тижні\r\n≈ 1,97 грн/день";
            // 
            // lbl_loveUA_tariff
            // 
            this.lbl_loveUA_tariff.AutoSize = true;
            this.lbl_loveUA_tariff.Location = new System.Drawing.Point(198, 0);
            this.lbl_loveUA_tariff.Name = "lbl_loveUA_tariff";
            this.lbl_loveUA_tariff.Size = new System.Drawing.Size(163, 380);
            this.lbl_loveUA_tariff.TabIndex = 2;
            this.lbl_loveUA_tariff.Text = resources.GetString("lbl_loveUA_tariff.Text");
            // 
            // lbl_LoveUABezmezh_tariff
            // 
            this.lbl_LoveUABezmezh_tariff.AutoSize = true;
            this.lbl_LoveUABezmezh_tariff.Location = new System.Drawing.Point(379, 0);
            this.lbl_LoveUABezmezh_tariff.Name = "lbl_LoveUABezmezh_tariff";
            this.lbl_LoveUABezmezh_tariff.Size = new System.Drawing.Size(179, 380);
            this.lbl_LoveUABezmezh_tariff.TabIndex = 4;
            this.lbl_LoveUABezmezh_tariff.Text = resources.GetString("lbl_LoveUABezmezh_tariff.Text");
            // 
            // lbl_LoveUaMaximum_tariff
            // 
            this.lbl_LoveUaMaximum_tariff.AutoSize = true;
            this.lbl_LoveUaMaximum_tariff.Location = new System.Drawing.Point(567, 0);
            this.lbl_LoveUaMaximum_tariff.Name = "lbl_LoveUaMaximum_tariff";
            this.lbl_LoveUaMaximum_tariff.Size = new System.Drawing.Size(182, 380);
            this.lbl_LoveUaMaximum_tariff.TabIndex = 5;
            this.lbl_LoveUaMaximum_tariff.Text = resources.GetString("lbl_LoveUaMaximum_tariff.Text");
            // 
            // lbl_LoveUaNoLimit_tariff
            // 
            this.lbl_LoveUaNoLimit_tariff.AutoSize = true;
            this.lbl_LoveUaNoLimit_tariff.Location = new System.Drawing.Point(755, 0);
            this.lbl_LoveUaNoLimit_tariff.Name = "lbl_LoveUaNoLimit_tariff";
            this.lbl_LoveUaNoLimit_tariff.Size = new System.Drawing.Size(175, 300);
            this.lbl_LoveUaNoLimit_tariff.TabIndex = 6;
            this.lbl_LoveUaNoLimit_tariff.Text = resources.GetString("lbl_LoveUaNoLimit_tariff.Text");
            // 
            // bn_yourNew_connect
            // 
            this.bn_yourNew_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bn_yourNew_connect.Location = new System.Drawing.Point(3, 391);
            this.bn_yourNew_connect.Name = "bn_yourNew_connect";
            this.bn_yourNew_connect.Size = new System.Drawing.Size(189, 67);
            this.bn_yourNew_connect.TabIndex = 7;
            this.bn_yourNew_connect.Text = "Підключити";
            this.bn_yourNew_connect.UseVisualStyleBackColor = true;
            // 
            // Tariffs
            // 
            this.Controls.Add(this.table_tariffs);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Tariffs";
            this.Size = new System.Drawing.Size(1043, 576);
            this.table_tariffs.ResumeLayout(false);
            this.table_tariffs.PerformLayout();
            this.table_tariffs_info.ResumeLayout(false);
            this.table_tariffs_info.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
