using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace NoClipper
{
    class Arquivo
    {
        private string diretorio;

        public Arquivo( string dir) {

            diretorio = dir;
        }

        
        public string[] Xmls()
        {
            return Directory.GetFiles(diretorio, "*.xml");
         
           
        }
    }
}
