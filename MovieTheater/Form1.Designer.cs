namespace MovieTheater
{
    partial class Form1
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
            this.flowArmchair = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxRezarvation = new DevExpress.XtraEditors.ListBoxControl();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblTotatSeats = new DevExpress.XtraEditors.LabelControl();
            this.lblSold = new DevExpress.XtraEditors.LabelControl();
            this.lblPurchasable = new DevExpress.XtraEditors.LabelControl();
            this.calcEditRezerve = new DevExpress.XtraEditors.CalcEdit();
            this.calcEditBuy = new DevExpress.XtraEditors.CalcEdit();
            this.calcEditPurchasable = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxRezarvation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditRezerve.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPurchasable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowArmchair
            // 
            this.flowArmchair.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowArmchair.Location = new System.Drawing.Point(0, 0);
            this.flowArmchair.Name = "flowArmchair";
            this.flowArmchair.Size = new System.Drawing.Size(658, 571);
            this.flowArmchair.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.calcEditPurchasable);
            this.groupControl1.Controls.Add(this.calcEditBuy);
            this.groupControl1.Controls.Add(this.calcEditRezerve);
            this.groupControl1.Controls.Add(this.lblPurchasable);
            this.groupControl1.Controls.Add(this.lblSold);
            this.groupControl1.Controls.Add(this.lblTotatSeats);
            this.groupControl1.Controls.Add(this.btnClean);
            this.groupControl1.Controls.Add(this.btnBuy);
            this.groupControl1.Controls.Add(this.listBoxRezarvation);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(658, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(231, 571);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // listBoxRezarvation
            // 
            this.listBoxRezarvation.Location = new System.Drawing.Point(0, 26);
            this.listBoxRezarvation.Name = "listBoxRezarvation";
            this.listBoxRezarvation.Size = new System.Drawing.Size(229, 219);
            this.listBoxRezarvation.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(5, 251);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(104, 60);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(115, 251);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 60);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblTotatSeats
            // 
            this.lblTotatSeats.Location = new System.Drawing.Point(5, 498);
            this.lblTotatSeats.Name = "lblTotatSeats";
            this.lblTotatSeats.Size = new System.Drawing.Size(40, 13);
            this.lblTotatSeats.TabIndex = 3;
            this.lblTotatSeats.Text = "Rezerve";
            // 
            // lblSold
            // 
            this.lblSold.Location = new System.Drawing.Point(6, 524);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(20, 13);
            this.lblSold.TabIndex = 3;
            this.lblSold.Text = "Sold";
            // 
            // lblPurchasable
            // 
            this.lblPurchasable.Location = new System.Drawing.Point(6, 550);
            this.lblPurchasable.Name = "lblPurchasable";
            this.lblPurchasable.Size = new System.Drawing.Size(58, 13);
            this.lblPurchasable.TabIndex = 3;
            this.lblPurchasable.Text = "Purchasable";
            // 
            // calcEditRezerve
            // 
            this.calcEditRezerve.Location = new System.Drawing.Point(82, 495);
            this.calcEditRezerve.Name = "calcEditRezerve";
            this.calcEditRezerve.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditRezerve.Properties.Precision = 0;
            this.calcEditRezerve.Properties.ReadOnly = true;
            this.calcEditRezerve.Size = new System.Drawing.Size(142, 20);
            this.calcEditRezerve.TabIndex = 4;
            // 
            // calcEditBuy
            // 
            this.calcEditBuy.Location = new System.Drawing.Point(82, 521);
            this.calcEditBuy.Name = "calcEditBuy";
            this.calcEditBuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditBuy.Properties.Precision = 0;
            this.calcEditBuy.Properties.ReadOnly = true;
            this.calcEditBuy.Size = new System.Drawing.Size(142, 20);
            this.calcEditBuy.TabIndex = 4;
            // 
            // calcEditPurchasable
            // 
            this.calcEditPurchasable.Location = new System.Drawing.Point(82, 547);
            this.calcEditPurchasable.Name = "calcEditPurchasable";
            this.calcEditPurchasable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditPurchasable.Properties.Precision = 0;
            this.calcEditPurchasable.Properties.ReadOnly = true;
            this.calcEditPurchasable.Size = new System.Drawing.Size(142, 20);
            this.calcEditPurchasable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 571);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.flowArmchair);
            this.Name = "Form1";
            this.Text = "Movie Theater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxRezarvation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditRezerve.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPurchasable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowArmchair;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxRezarvation;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnBuy;
        private DevExpress.XtraEditors.LabelControl lblSold;
        private DevExpress.XtraEditors.LabelControl lblTotatSeats;
        private DevExpress.XtraEditors.LabelControl lblPurchasable;
        private DevExpress.XtraEditors.CalcEdit calcEditRezerve;
        private DevExpress.XtraEditors.CalcEdit calcEditPurchasable;
        private DevExpress.XtraEditors.CalcEdit calcEditBuy;
    }
}

