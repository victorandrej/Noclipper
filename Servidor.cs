using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
    class Servidor
    {
       public string Usuario { get; set; } = Properties.Settings.Default.UsuarioServidor;
        public string SenhaUsuario { get; set; } = Properties.Settings.Default.SenhaServidor;
       public string PortaServidor { get; set; } = Properties.Settings.Default.PortaServidor;
       public string Endereco { get; set; } = Properties.Settings.Default.EnderecoServidor;
        public string BancoDeDados { get; set; } = Properties.Settings.Default.BancoDeDados;
    }
}
