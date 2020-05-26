using BLL;
using DAL.Factory;
using DAL.Repositories.Memory;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Riveros
{
    public partial class Form1 : Form
    {
        //ClienteRepository clientes = new ClienteRepository();

        ClienteRepository clientes = new BLL.GetAll();


        public Form1()
        {

            InitializeComponent();

        }

        private void textBoxTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            clientes.UpdateDepositar(this.textBoxNroCuenta.Text, this.textBoxMonto.Text);
            this.labelMsgSaldo.Text = "Transaccion finalizada correctamente";
            

        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            clientes.UpdateExtraer (this.textBoxNroCuenta.Text, this.textBoxMonto.Text);
            this.labelMsgSaldo.Text = "Transaccion finalizada correctamente";


        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            clientes.UpdateTransferir(this.textBoxNroCuenta.Text, this.textBoxNroCuentaTransferir.Text,  this.textBoxMonto.Text);
            this.labelMsgSaldo.Text = "Transaccion finalizada correctamente";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            this.labelMsgSaldo.AutoSize = true;
            this.labelMsgSaldo.Text = "";

            List<Cliente> cli = clientes.clientesCuentas;
            List<Cuenta> msg = RecorrerCuentas(cli);

            foreach (var detalle in msg)
            {
                this.labelMsgSaldo.Text += "Cuenta numero : " + detalle.Numero + " Saldo:  " + detalle.Saldo;
            }
        }

        private static List<Cuenta> RecorrerCuentas(List<Cliente> clientes)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            foreach (var cliente in clientes)
            {
                foreach (var cuenta in cliente.Cuentas)
                {
                    cuentas.Add(cuenta);

                }

            }

            return cuentas;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNroCuentaTransferir_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }


   


