using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GestRest.Properties;
using Utils;

namespace GestRest
{
    partial class dlgCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnMesAnterior = new System.Windows.Forms.Button();
            this.btnMesSiguiente = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 69);
            this.panel1.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpTop.Controls.Add(this.btnMesAnterior, 0, 0);
            this.tlpTop.Controls.Add(this.btnMesSiguiente, 2, 0);
            this.tlpTop.Controls.Add(this.lblMes, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpTop.Size = new System.Drawing.Size(994, 69);
            this.tlpTop.TabIndex = 0;
            // 
            // btnMesAnterior
            // 
            this.btnMesAnterior.BackgroundImage = global::GestRest.Properties.Resources.flecha_izq;
            this.btnMesAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesAnterior.Location = new System.Drawing.Point(3, 3);
            this.btnMesAnterior.Name = "btnMesAnterior";
            this.btnMesAnterior.Size = new System.Drawing.Size(143, 63);
            this.btnMesAnterior.TabIndex = 0;
            this.btnMesAnterior.UseVisualStyleBackColor = true;
            this.btnMesAnterior.Click += new System.EventHandler(this.btnMesAnterior_Click);
            // 
            // btnMesSiguiente
            // 
            this.btnMesSiguiente.BackgroundImage = global::GestRest.Properties.Resources.flecha_der;
            this.btnMesSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesSiguiente.Location = new System.Drawing.Point(847, 3);
            this.btnMesSiguiente.Name = "btnMesSiguiente";
            this.btnMesSiguiente.Size = new System.Drawing.Size(144, 63);
            this.btnMesSiguiente.TabIndex = 1;
            this.btnMesSiguiente.UseVisualStyleBackColor = true;
            this.btnMesSiguiente.Click += new System.EventHandler(this.btnMesSiguiente_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(152, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(689, 69);
            this.lblMes.TabIndex = 2;
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpCenter
            // 
            this.tlpCenter.ColumnCount = 9;
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenter.Location = new System.Drawing.Point(0, 69);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.RowCount = 7;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCenter.Size = new System.Drawing.Size(994, 649);
            this.tlpCenter.TabIndex = 1;
            // 
            // dlgCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 718);
            this.Controls.Add(this.tlpCenter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgCalendario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendari";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlgCalendario_FormClosing);
            this.Load += new System.EventHandler(this.dlgCalendario_Load);
            this.panel1.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlpTop;
        private TableLayoutPanel tlpCenter;
        private Button btnMesAnterior;
        private Button btnMesSiguiente;
        private Label lblMes;
    }
}