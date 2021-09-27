using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioTecnico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Console
    {
        // GET: api/Console/5
        [HttpGet("{numero}")]
        public IActionResult CalcularDivisoresEPrimos(int numero)
        {
            string numeroEntrada = numero.ToString();
            RetornaNumerosDivisoresResponse retornaNumerosDivisoresResponse = RetornaNumerosDivisores(numero);
            string numerosDivisores = retornaNumerosDivisoresResponse.numerosDivisores;
            List<int> numerosPrimos2 = retornaNumerosDivisoresResponse.numerosPrimos;

            string numerosPrimos = string.Empty;
            foreach (int i in numerosPrimos2)
            {
                if (ePrimo(i))
                    numerosPrimos += i.ToString() + ", ";
            }
            numerosPrimos = numerosPrimos.Remove(numerosPrimos.Length - 2, 2);

            return new JsonResult(new { numeroEntrada, numerosDivisores, numerosPrimos });
        }
        private static bool ePrimo(int num)
        {
            bool isPrimo = true;
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    isPrimo = false;
                    break;
                }
            }
            return isPrimo;
        }

        private static RetornaNumerosDivisoresResponse RetornaNumerosDivisores(int numero)
        {
            string numerosDivisores = string.Empty;
            List<int> numerosPrimos = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    numerosDivisores += i.ToString() + ", ";
                    numerosPrimos.Add(i);
                }
            }
            return new RetornaNumerosDivisoresResponse() { numerosDivisores = numerosDivisores.Remove(numerosDivisores.Length - 2, 2), numerosPrimos = numerosPrimos};
        }


        private class RetornaNumerosDivisoresResponse
        {
            public RetornaNumerosDivisoresResponse()
            {

            }

            public RetornaNumerosDivisoresResponse(List<int> numerosPrimos, string numerosDivisores)
            {
                this.numerosPrimos = numerosPrimos;
                this.numerosDivisores = numerosDivisores;
            }

            public List<int> numerosPrimos { get; set; }
            public string numerosDivisores { get; set; }
        }
    }
}
