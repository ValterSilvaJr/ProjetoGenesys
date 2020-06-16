using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGenesys.App.controller
{
    public class AbrirChildForm
    {
        private static Form formularioAtivo = null;
        public static Form exibirFormularioChild(Form childForm, Panel pnlChildForm)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
            }

            formularioAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            return childForm;
        }
    }
}
