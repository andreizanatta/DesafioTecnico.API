using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class RetornaNumerosDivisoresResponse
    {
        public RetornaNumerosDivisoresResponse()
        {

        }

        public RetornaNumerosDivisoresResponse(List<int> numerosPrimos, string numerosDivisores)
        {
            this.numerosPrimos2 = numerosPrimos;
            this.numerosDivisores = numerosDivisores;
        }

        public List<int> numerosPrimos2 { get; set; }
        public string numerosDivisores { get; set; }
    }
}
