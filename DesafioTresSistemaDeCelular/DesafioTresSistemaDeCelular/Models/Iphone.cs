using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTresSistemaDeCelular.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero,modelo,imei,memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }


        //public override void InstalarAplicativo(string nomeApp)  tambem pode ser feito dessa forma, usando o sistema de herança
        //    {
        //        base.InstalarAplicativo(nomeApp);
        //    }
    }
}
