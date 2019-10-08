using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    public static class Utilidades
    {

        public static decimal convertirSeparadorDecimal(string _textDecimal)
        {
            _textDecimal = _textDecimal.ToString().Trim();

            decimal decimalAconvertir = 0;

            if (_textDecimal == "" || _textDecimal == null)
            {
                return decimalAconvertir;
            }

            try
            {
                if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",")
                {
                    decimalAconvertir = decimal.Parse(_textDecimal.Replace(".", ","));

                }

                if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
                {

                    decimalAconvertir = decimal.Parse(_textDecimal.Replace(",", "."));

                }
                decimalAconvertir = Convert.ToDecimal(string.Format("{0:F2}", decimalAconvertir));
            }
            catch (Exception)
            {

                decimalAconvertir = 0;
            }


            return decimalAconvertir;
        }


        public static bool esInt(string _texto)
        {
            int numero = 0;
            string valor_validar = _texto.ToString().Trim();
            bool result = int.TryParse(valor_validar, out numero); //i now = 108 
            return result;
        }

        public static bool esDecimal(string _texto)
        {
            decimal numero = 0;
            string valor_validar = _texto.ToString().Trim();

            bool result = decimal.TryParse(valor_validar, out numero); //i now = 108 
            return result;
        }



        public static decimal formatoDecimal(decimal _decimal)
        {

            _decimal = Convert.ToDecimal(string.Format("{0:F2}", _decimal));
            return _decimal;
        }

    }
}
