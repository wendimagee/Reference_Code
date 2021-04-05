using System;
using System.Collections.Generic;
using System.Text;

namespace TDDExercises
{
    public class PasswordVerifier
    {
        public string Verify(string password)
        {
            if (password.Length > 8)
            {
                return "good Password";
            }
            else
            {
                return "the password is not long enough";
            }

        }
    }
}
