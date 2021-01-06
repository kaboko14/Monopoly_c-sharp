
namespace Monopoly
{
    partial class LandSquareControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LandPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LandRentalPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LandName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "価格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "レンタル料";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LandPrice
            // 
            this.LandPrice.AutoSize = true;
            this.LandPrice.Location = new System.Drawing.Point(80, 101);
            this.LandPrice.Name = "LandPrice";
            this.LandPrice.Size = new System.Drawing.Size(67, 24);
            this.LandPrice.TabIndex = 3;
            this.LandPrice.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(153, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "万円";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(153, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "万円";
            // 
            // LandRentalPrice
            // 
            this.LandRentalPrice.AutoSize = true;
            this.LandRentalPrice.Location = new System.Drawing.Point(80, 130);
            this.LandRentalPrice.Name = "LandRentalPrice";
            this.LandRentalPrice.Size = new System.Drawing.Size(67, 24);
            this.LandRentalPrice.TabIndex = 6;
            this.LandRentalPrice.Text = "label6";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 39);
            this.panel2.TabIndex = 7;
            // 
            // LandName
            // 
            this.LandName.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LandName.Location = new System.Drawing.Point(7, 65);
            this.LandName.Name = "LandName";
            this.LandName.Size = new System.Drawing.Size(186, 36);
            this.LandName.TabIndex = 8;
            this.LandName.Text = "label7";
            this.LandName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LandSquareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LandName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LandRentalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LandPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LandSquareControl";
            this.Size = new System.Drawing.Size(198, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LandPrice;
        public System.Windows.Forms.Label LandRentalPrice;
        public System.Windows.Forms.Label LandName;
    }
}
