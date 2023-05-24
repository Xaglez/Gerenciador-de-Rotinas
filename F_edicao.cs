using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotina
{
    public partial class F_edicao : Form
    {
        public F_edicao()
        {
            InitializeComponent();
        }
        private void adicionarItem()
        {
            if (!String.IsNullOrWhiteSpace(tb_adicionar.Text))
            {
                clb_editar.Items.Add(tb_adicionar.Text.ToUpper(), false);
                tb_adicionar.Clear();
                tb_adicionar.Focus();
            }
            else
            {
                tb_adicionar.Focus();
            }
        }

        private void bnt_adicionar_Click(object sender, EventArgs e)
        {            
            adicionarItem();
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_editar.Items.Clear();
        }

        private void btn_marcarTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_editar.Items.Count; i++)
            {
                clb_editar.SetItemChecked(i, true);
            }
        }

        private void btn_desmarcarTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_editar.Items.Count; i++)
            {
                clb_editar.SetItemChecked(i, false);
            }
        }

        private void tb_adicionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                adicionarItem();
            }
        }

        private void tb_adicionar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                adicionarItem();
            }
        }
    }
}
