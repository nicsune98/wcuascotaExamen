using System;
using System.Collections.Generic;
using System.Text;

namespace wcuascotaExamen
{
    internal class Validacion
    {
        public static bool ValidacionNumerica(string input)
        {
            try
            {
                double value = double.Parse(input);

                if (value < 1 || value > 3000)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
