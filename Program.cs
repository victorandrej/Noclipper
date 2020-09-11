using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoClipper
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login Login = new Login();
            Banco banco = new Banco();
            //if (banco.TestarConexao())
            //{
            //    if (Login.ShowDialog() == DialogResult.Yes)
            //    {
            //        Application.Run(new FormularioPrincipal(Login.usuario));
            //    }
            //}
            //else {
            //    CadastroDeBancoDeDados cadastroDeBancoDeDados = new CadastroDeBancoDeDados();
            //    if (cadastroDeBancoDeDados.ShowDialog() == DialogResult.OK) {
            //        if (Login.ShowDialog() == DialogResult.Yes)
            //        {
            //            Application.Run(new FormularioPrincipal(Login.usuario));
            //        }
            //    }
            //}

            try
            {
                banco.TestarConexao();
            }
            catch
            {
                CadastroDeBancoDeDados cadastroDeBancoDeDados = new CadastroDeBancoDeDados();
                if (cadastroDeBancoDeDados.ShowDialog() != DialogResult.OK)
                    return;
            }

            if (Login.ShowDialog() == DialogResult.Yes)
                Application.Run(new FormularioPrincipal(Login.usuario));

        }





    }
}

