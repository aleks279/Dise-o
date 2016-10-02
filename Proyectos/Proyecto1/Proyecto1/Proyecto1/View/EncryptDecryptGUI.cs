using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.View
{
    public partial class EncryptDecryptGUI : Form
    {
        private string _ResultadoEncrypt;
        private string _ResultadoDecrypt;
        private string _ultimoAlgEncrypt;
        private string _ultimoTipoEncrypt;
        private string _ultimoAlgDecrypt;
        private string _ultimoTipoDecrypt;
        public void init()
        {
            InitializeComponent();
            this._ResultadoDecrypt = "";
            this._ResultadoEncrypt = "";
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (this.algOptCB.SelectedIndex != -1 && noEsStringVacio(this.contentEncryptTB.Text))
            {
                string data = this.contentEncryptTB.Text;
                string encryptedData = encrypt(data);
                this._ultimoAlgEncrypt = this.algOptCB.Text;
                this._ultimoTipoEncrypt = "encriptación";
                this.encryptedContentTB.Text = decorateHeader(this._ultimoTipoEncrypt, encryptedData, this._ultimoAlgEncrypt);
                this._ResultadoEncrypt = encryptedData;
            }
        }

        private void decryptedBtn_Click(object sender, EventArgs e)
        {
            if (this.algOptCB.SelectedIndex != -1 && noEsStringVacio(this._ResultadoEncrypt))
            {
                string data = this._ResultadoEncrypt;
                string decryptedData = decrypt(data);
                this._ultimoAlgDecrypt = this.algOptCB.Text;
                this._ultimoTipoDecrypt = "desencriptación";
                this.decryptedContentTB.Text = decorateHeader(this._ultimoTipoDecrypt, decryptedData, this._ultimoAlgDecrypt);
                this._ResultadoDecrypt = decryptedData;
            }
        }
        public string decorateHeader(string tipoOp, string modifiedData, string pAlgoritmo)
        {
            string resultado = "Tipo de operación: ";
            resultado += tipoOp + ", Método: " + pAlgoritmo + ", Resultado: " + modifiedData;
            return resultado;
        }

        private void saveTransitionTB_Click(object sender, EventArgs e)
        {
            string filename = this.fileNameTB.Text;
            string formato = this.formatoCB.Text;
            if (this.formatoCB.SelectedIndex != -1 && noEsStringVacio(this._ResultadoEncrypt) && noEsStringVacio(filename))
            {
                this._ControllerSave.save(this._ResultadoEncrypt, this._ultimoAlgEncrypt, this._ultimoTipoEncrypt,
                    formato, filename);
                if (noEsStringVacio(this._ResultadoDecrypt))
                {
                    this._ControllerSave.save(this._ResultadoDecrypt, this._ultimoAlgDecrypt, this._ultimoTipoDecrypt,
                        formato, filename);
                }
            }
        }
        private bool noEsStringVacio(String str)
        {
            return str != "";
        }
    }
}
