using System.Security.Cryptography;
using System.Text;

namespace Laboratoire___Cassage_de_mots_de_passe
{
    internal class Program
    {
        static string Hash(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = MD5.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }

        static void Main(string[] args)
        {
            List<String> list = new List<string> {
                "th45",
                "tht7tu",
                "thjoi75",
                "vcb798",
                "#%$654",
                "534dfs#",
                "8u94%",
                "354345d",
                "*(&hyh*&",
                "^t*b#$h%",
                "&*^h#$",
                "(&*%*&",
                "^*&g%^&(%",
                "(^h&*%tno",
                "&*^h(t(*&%g(",
                "^(*)bn&t$"
            };

            using (StreamWriter outputFile = new StreamWriter(Path.Combine("", "output.txt")))
            {
                foreach (string s in list)
                    outputFile.WriteLine(Hash(s));
            }
        }
        
    }
}