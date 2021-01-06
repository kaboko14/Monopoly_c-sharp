
namespace Monopoly
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Monopoly.DataSet();
            this.MapPamel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataTableBindingSource
            // 
            this.userDataTableBindingSource.DataMember = "UserDataTable";
            this.userDataTableBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MapPamel
            // 
            this.MapPamel.Location = new System.Drawing.Point(39, 57);
            this.MapPamel.Name = "MapPamel";
            this.MapPamel.Size = new System.Drawing.Size(976, 906);
            this.MapPamel.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.UserPanel.Location = new System.Drawing.Point(1044, 65);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(851, 389);
            this.UserPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1230);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.MapPamel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            ((System.ComponentModel.ISupportInitialize)(this.userDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userDataTableBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.Panel MapPamel;
        private System.Windows.Forms.Panel UserPanel;
    }
}

