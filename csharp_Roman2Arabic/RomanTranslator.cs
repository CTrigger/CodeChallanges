using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{

    public enum RomanMap
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000

    }

    class RomanTranslator
    {
        #region variables
        private string Input { get; set; }
        public int Value { get; set; }

        #endregion
        #region Ctor
        public RomanTranslator(string _input)
        {
            this.Input = _input;
            this.Value = 0;
        }

        #endregion

        public void ConvertRomanToArabic()
        {
            int i = 0;
            int j = 0;
            bool first = true;
            foreach (char item in this.Input)
            {

                if (first)
                {
                    first = false;
                    j = (int)Enum.Parse(typeof(RomanMap), item.ToString());
                    
                }
                else
                {
                    i = j;
                    j = (int)Enum.Parse(typeof(RomanMap), item.ToString());
                    
                    if (i < j)
                    {
                        this.Value -= i;
                    }
                    else
                    {
                        this.Value += i;
                    }
                }
            }
            this.Value += j;

        }
    }
}
