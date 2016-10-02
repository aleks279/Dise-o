using System;
using Proyecto1.Control;
using System.Collections.Generic;

namespace Proyecto1.View
{
    partial class EncryptDecryptGUI:IUserOperations
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
            this.label1 = new System.Windows.Forms.Label();
            this.contentEncryptTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.algOptCB = new System.Windows.Forms.ComboBox();
            this.encryptedContentTB = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptedContentTB = new System.Windows.Forms.TextBox();
            this.decryptedBtn = new System.Windows.Forms.Button();
            this.saveTransitionTB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formatoCB = new System.Windows.Forms.ComboBox();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserte el texto que desea encriptar:";
            // 
            // contentEncryptTB
            // 
            this.contentEncryptTB.Location = new System.Drawing.Point(21, 24);
            this.contentEncryptTB.Multiline = true;
            this.contentEncryptTB.Name = "contentEncryptTB";
            this.contentEncryptTB.Size = new System.Drawing.Size(562, 123);
            this.contentEncryptTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el método de encriptación";
            // 
            // algOptCB
            // 
            this.algOptCB.FormattingEnabled = true;
            try
            {
                this.algOptCB.Items.AddRange(new object[] {
                this._MisMetodos[0],
                this._MisMetodos[1],
                this._MisMetodos[2],
                this._MisMetodos[3]});
            }
            catch (Exception error)
            {
                Console.Write(error.Message);
            }
            this.algOptCB.Location = new System.Drawing.Point(310, 153);
            this.algOptCB.Name = "algOptCB";
            this.algOptCB.Size = new System.Drawing.Size(273, 21);
            this.algOptCB.TabIndex = 3;
            // 
            // encryptedContentTB
            // 
            this.encryptedContentTB.Location = new System.Drawing.Point(21, 213);
            this.encryptedContentTB.Multiline = true;
            this.encryptedContentTB.Name = "encryptedContentTB";
            this.encryptedContentTB.Size = new System.Drawing.Size(562, 123);
            this.encryptedContentTB.TabIndex = 4;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(508, 184);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encriptar";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptedContentTB
            // 
            this.decryptedContentTB.Location = new System.Drawing.Point(21, 371);
            this.decryptedContentTB.Multiline = true;
            this.decryptedContentTB.Name = "decryptedContentTB";
            this.decryptedContentTB.Size = new System.Drawing.Size(562, 123);
            this.decryptedContentTB.TabIndex = 6;
            // 
            // decryptedBtn
            // 
            this.decryptedBtn.Location = new System.Drawing.Point(508, 342);
            this.decryptedBtn.Name = "decryptedBtn";
            this.decryptedBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptedBtn.TabIndex = 7;
            this.decryptedBtn.Text = "Desencriptar";
            this.decryptedBtn.UseVisualStyleBackColor = true;
            this.decryptedBtn.Click += new System.EventHandler(this.decryptedBtn_Click);
            // 
            // saveTransitionTB
            // 
            this.saveTransitionTB.Location = new System.Drawing.Point(508, 503);
            this.saveTransitionTB.Name = "saveTransitionTB";
            this.saveTransitionTB.Size = new System.Drawing.Size(75, 23);
            this.saveTransitionTB.TabIndex = 8;
            this.saveTransitionTB.Text = "Guardar";
            this.saveTransitionTB.UseVisualStyleBackColor = true;
            this.saveTransitionTB.Click += new System.EventHandler(this.saveTransitionTB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileNameTB);
            this.panel1.Controls.Add(this.formatoCB);
            this.panel1.Controls.Add(this.contentEncryptTB);
            this.panel1.Controls.Add(this.saveTransitionTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.decryptedBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.decryptedContentTB);
            this.panel1.Controls.Add(this.algOptCB);
            this.panel1.Controls.Add(this.encryptBtn);
            this.panel1.Controls.Add(this.encryptedContentTB);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 541);
            this.panel1.TabIndex = 9;
            // 
            // formatoCB
            // 
            this.formatoCB.FormattingEnabled = true;
            try
            {
                this.formatoCB.Items.AddRange(new object[] {
                this._MisFormatos[0],
                this._MisFormatos[1],
                this._MisFormatos[2]});
            }
            catch (Exception error)
            {
                Console.Write(error.Message);
            }
            this.formatoCB.Location = new System.Drawing.Point(381, 504);
            this.formatoCB.Name = "formatoCB";
            this.formatoCB.Size = new System.Drawing.Size(121, 21);
            this.formatoCB.TabIndex = 9;
            // 
            // fileNameTB
            // 
            this.fileNameTB.Location = new System.Drawing.Point(21, 504);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(354, 20);
            this.fileNameTB.TabIndex = 10;
            // 
            // EncryptDecryptGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 540);
            this.Controls.Add(this.panel1);
            this.Name = "EncryptDecryptGUI";
            this.Text = "EncryptDecryptGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public string encrypt(string pData)
        {
            return this._ControllerEncrypt.encrypt(pData, this.algOptCB.Text);
        }

        public string decrypt(string pData)
        {
            return this._ControllerEncrypt.decrypt(pData, this.algOptCB.Text);
        }

        public void setController(EncryptDecryptController pControllerEncrypt, SaveController pControllerSave)
        {
            this._ControllerEncrypt = pControllerEncrypt;
            this._MisMetodos = this._ControllerEncrypt.getMisMetodos();
            this._ControllerSave = pControllerSave;
            this._MisFormatos = this._ControllerSave.obtenerMisFormatos();
        }

        public void save(string pResultado, string pAlgorimo, string pTipoOp)
        {
            this._ControllerSave.save(pResultado, pAlgorimo, pTipoOp, this.formatoCB.Text, this.fileNameTB.Text);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentEncryptTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox algOptCB;
        private System.Windows.Forms.TextBox encryptedContentTB;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox decryptedContentTB;
        private System.Windows.Forms.Button decryptedBtn;
        private System.Windows.Forms.Button saveTransitionTB;
        private System.Windows.Forms.Panel panel1;
        private EncryptDecryptController _ControllerEncrypt;
        private SaveController _ControllerSave;
        private List<string> _MisMetodos;
        private List<string> _MisFormatos;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.ComboBox formatoCB;
    }
}