using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBox
{
    internal static class ErrorManager
    {
        private static readonly Stack<string> Errors = new Stack<string>();

        public static void AddError(string error)
        {
            Errors.Push(error);
        }

        public static string GetMostRecentError()
        {
            if(!Errors.TryPop(out string error))
            {
                return string.Empty;
            }

            return error;
        }

        public static bool AnyErrors()
        {
            return Errors.Any();
        }
    }
}
