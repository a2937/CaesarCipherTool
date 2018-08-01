using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCypherApplierCSharp
{
    public static class CypherTool
    {
        /**
         * Takes a word one character at time,
         * then unscrambles the cypher. 
         * 
         * @param keyCodes : The phrase to be restored
         * @param rawAscii : if the phrase in ascii format, defaults to true
         * @param shift : the shift for the cypher, defaults to 0
         * @param separater : the seperator for the text, defaults to a double quotation mark.
         */
        public static String DecodeCypher(String keyCodes,bool rawAscii = true, int shift = 0, char separater = '\"')
        {
            StringBuilder builder = new StringBuilder(); 
            String[] keys = keyCodes.Split(separater);
            foreach(String key in keys)
            {
                if(rawAscii)
                {
                    bool parsed = int.TryParse(key, out int number);
                    if(parsed)
                    {
                        number -= shift;
                        builder.Append((char)number);
                    }
                }
                else
                {
                    char value = key.ToCharArray()[0];
                    int number = value - shift;
                    builder.Append((char)number);
                }
               
               
            }
            return builder.ToString(); 
        }


        /**
         * Takes a word one character at time,
         * then shifts it. 
         * 
         * @param keyCodes : The phrase to be encoded
         * @param rawAscii : if the phrase in ascii format, defaults to true
         * @param shift : the shift for the cypher, defaults to 0
         * @param separater : the seperator for the text, defaults to a double quotation mark.
         */
        public static String EncodeCypher(String keyCodes, bool rawAscii = true, int shift = 0, char separater = '\"')
        {
            StringBuilder builder = new StringBuilder();
            String[] keys = keyCodes.Split(separater);
            foreach (String key in keys)
            {
                if (rawAscii)
                {
                    bool parsed = int.TryParse(key, out int number);
                    if (parsed)
                    {
                        number += shift;
                        builder.Append((char)number);
                    }
                }
                else
                {
                    char value = key.ToCharArray()[0];
                    int number = value + shift;
                    builder.Append((char)number);
                }


            }
            return builder.ToString();
        }
    }
}
