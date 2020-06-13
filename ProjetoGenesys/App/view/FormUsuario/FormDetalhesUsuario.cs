using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGenesys.App.model;

namespace ProjetoGenesys.App.view
{
    public partial class FormDetalhesUsuario : Form
    {
        public FormDetalhesUsuario(string idUsuario)
        {
            InitializeComponent();

            UsuarioDao usuarioDao = new UsuarioDao();
            usuarioDao.ListarDetalhesUsuario(dgvDetalhes, idUsuario);
        }
    }
}
