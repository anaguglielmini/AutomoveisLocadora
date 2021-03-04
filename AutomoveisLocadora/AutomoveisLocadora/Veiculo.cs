using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomoveisLocadora
{
    class Veiculo
    {
        public string placaV, descV, marcaV, modeloV;
        public int Id;
        public double precoV;
        public bool statusV;
        public DateTime retiradaV, devolucaoV = DateTime.Now.Date;

    }
}
