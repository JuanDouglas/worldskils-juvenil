using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSCAlagoas
{
    static class GetInt
    {
        public static int Get(string value) {
            string text = " ";
            string numbers = "0123456789";
            foreach (char letter in value) {
                foreach (char number in numbers) {
                    if (letter == number) text += (letter);
                }
            }
            return int.Parse(text);
        }
    }
}
