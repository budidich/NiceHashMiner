﻿namespace NiceHashMiner.Forms.Components {
    partial class AlgorithmsListView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listViewAlgorithms = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // listViewAlgorithms
            // 
            this.listViewAlgorithms.CheckBoxes = true;
            this.listViewAlgorithms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAlgorithms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAlgorithms.FullRowSelect = true;
            this.listViewAlgorithms.GridLines = true;
            this.listViewAlgorithms.HideSelection = false;
            this.listViewAlgorithms.Location = new System.Drawing.Point(0, 0);
            this.listViewAlgorithms.MultiSelect = false;
            this.listViewAlgorithms.Name = "listViewAlgorithms";
            this.listViewAlgorithms.Size = new System.Drawing.Size(539, 380);
            this.listViewAlgorithms.TabIndex = 11;
            this.listViewAlgorithms.UseCompatibleStateImageBehavior = false;
            this.listViewAlgorithms.View = System.Windows.Forms.View.Details;
            this.listViewAlgorithms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewAlgorithms_MouseClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Enabled";
            this.columnHeader0.Width = 63;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Algorithm";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Miner";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Speeds";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ratio BTC/GH/Day";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BTC/Day";
            this.columnHeader5.Width = 134;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AlgorithmsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.listViewAlgorithms);
            this.Name = "AlgorithmsListView";
            this.Size = new System.Drawing.Size(539, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlgorithms;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
