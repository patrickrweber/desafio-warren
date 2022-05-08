using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarrenTech
{
    class Metodos
    {
        #region Inverter Numero
        public int InverterNumero(int numero)
        {
            int inverso = 0;
            while (numero > 0)
            {
                inverso = 10 * inverso + numero % 10;
                if (inverso == 0)
                {
                    goto Fim;
                }
                numero /= 10;
            }
        Fim:
            return inverso;
        }
        #endregion

        #region Contar Digitos
        public int ContarDigitos(int soma)
        {
            int qtdDigitos = 0;
            while (soma > 0)
            {
                qtdDigitos++;
                soma /= 10;
            }
            return qtdDigitos;
        }
        #endregion

        #region Verificar Reversibilidade
        public int VerificarReversibilidade(int soma)
        {
            int impares = 0;
            while (soma > 0)
            {
                int digito = soma % 10;
                    if (digito % 2 == 1 && digito != 0)
                    {
                        impares++;
                    }
                soma /= 10;
            }
            return impares;
        }
        #endregion

    }
}
