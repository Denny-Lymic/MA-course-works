using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Class_stud
{
    //Implement class Morse_matrix derived from String_matrix, which realize IMorse_crypt
    class Morse_matrix : String_matrix, IMorse_crypt
    {
        public const int Size_2 = Alphabet.Size;
        private int offset_key;

        //**************************************

        //Implement Morse_matrix constructor with the int parameter for offset
        //Use fd(Alphabet.Dictionary_arr) and sd() methods

        public Morse_matrix(int offset_key = 0)
        {
            this.offset_key = offset_key;
            fd(Alphabet.Dictionary_arr);
            sd();
        }

        //**************************************

        //Implement Morse_matrix constructor with the string [,] Dict_arr and int parameter for offset
        //Use fd(Dict_arr) and sd() methods

        public Morse_matrix(string[,] Dict_arr, int offset_key = 0)
        {
            this.offset_key = offset_key;
            fd(Dict_arr);
            sd();
        }

        private void fd(string[,] Dict_arr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size_2; jj++)
                    this[ii, jj] = Dict_arr[ii, jj];
        }


        private void sd()
        {
            int off = Size_2 - offset_key;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offset_key];
            for (int jj = off; jj < Size_2; jj++)
                this[1, jj] = Alphabet.Dictionary_arr[1, jj - off];
        }

        //**************************************

        //Implement Morse_matrix operator +

        public static Morse_matrix operator +(Morse_matrix obj, int offset_key)
        {
            int newOffset_key = obj.offset_key + offset_key;
            if (newOffset_key > 34) newOffset_key -= Size2;
            else if (newOffset_key < 0) newOffset_key += Size2;

            Morse_matrix returnMatrix = new Morse_matrix(newOffset_key);

            return returnMatrix;
        }

        //**************************************

        //Realize crypt() with string parameter
        //Use indexers

        public string crypt(string word)
        {
            string result = "";

            for(int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j < Size_2; j++)
                {
                    if (word[i] == char.Parse(this[0, j]))
                    {
                        result += this[1, j];
                        /*result += cryptedStr(j);*/
                        break;
                    }
                }
            }

            return result;
        }

        //To return morse code without shift

        /*private string cryptedStr(int j)
        {
            int currJ = j - offset_key < 0 ? j - offset_key + Size_2 : j - offset_key;
            return this[1, currJ];
        }*/

        //**************************************

        //Realize decrypt() with string array parameter
        //Use indexers

        public string decrypt(string[] signals)
        {
            string result = "";

            for (int i = 0; i < signals.Length; i++)
            {
                for (int j = 0; j < Size_2; j++)
                {
                    if (signals[i] == this[1, j])
                    {
                        result += this[0, j];
                        /*result += decryptedStr(j);*/
                        break;
                    }
                }
            }
            return result;
        }

        //To return letter without shift (works only with cryptedStr(int j))

        /*private string decryptedStr(int j)
        {
            int currJ = j + offset_key > Size_2 - 1 ? j + offset_key - Size_2 : j + offset_key;
            return this[0, currJ];
        }*/

        //**************************************

        //Implement Res_beep() method with string parameter to beep the string

        public void Res_beep(string result)
        {
            for( int i = 0; i < result.Length; i++)
            {
                if (result[i] == '.')
                {
                    Console.Beep(700, 200);
                    continue;
                }
                if (result[i] == '-')
                {
                    Console.Beep(700, 500);
                    continue;
                }
                Thread.Sleep(200);
            }
        }       
    }
}
