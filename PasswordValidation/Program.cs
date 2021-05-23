/****************************************************************************************
 * Very Hard Level of Difficulty
 * 
 * Create a function that validates a password to conform to the following rules:
 *  Length between 6 and 24 characters.
 *  At least one uppercase letter (A-Z).
 *  At least one lowercase letter (a-z).
 *  At least one digit (0-9).
 *  Maximum of 2 repeated characters.
 *      - "aa" is OK 👍
 *      - "aaa" is NOT OK 👎
 *  Supported special characters:
 *      - ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .
 * 
 * ValidatePassword("P1zz@") ➞ false
 * // Too short.
 * 
 * ValidatePassword("iLoveYou") ➞ false
 * // Missing a number.
 * 
 * ValidatePassword("Fhg93@") ➞ true
 * // OK!
 * 
 * Approach:
 * Check user pssword -> string
 * Parse through string
 * Check to make sure it contains 6-24 chars, at least 1 upercase, at least 1 lowercase,
 *  at least 1 digit, max 2 repeated chars, the special chars
 * Else print the error message
*******************************************************************************************/
using System;
using System.Linq;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean passwordOk = ValidatePassword("P1zz@");
            //Boolean passwordOk = ValidatePassword("iLoveYou");
            //Boolean passwordOk = ValidatePassword("Fhg93@");
            //Boolean passwordOk = ValidatePassword("Fhg93@zzz");
            Boolean passwordOk = ValidatePassword("/1Up@aa");   //SHOULD RETURN FALSE, check the inner most case in nested if
            Console.WriteLine(passwordOk);
        }

        static public Boolean ValidatePassword(string password)
        {
            Boolean passwordIsOK = false;
            string specialChar = "!@#$%^&*()+=_-{}[]:;\"'?<>,.";

            if (password.Length > 5 && password.Length < 23)
            {
                if (password.ToCharArray().Any(char.IsUpper))
                {
                    if (password.ToCharArray().Any(char.IsLower))
                    {
                        if (password.ToCharArray().Any(char.IsDigit))
                        {
                            passwordIsOK = true;
                            //Optional chars user can add to password
                            if (!IsOK(password))
                            {
                                passwordIsOK = false;
                                if (!password.Contains(specialChar))
                                    passwordIsOK = false;
                            }                            
                        }
                        else
                            Console.WriteLine("Password must contain at least one digit.");
                    }
                    else
                        Console.WriteLine("Password must contain at least one lowercase.");
                }
                else
                    Console.WriteLine("Password must contain at least one uppercase.");
            }
            else
                Console.WriteLine("Password must be between 6 to 24 characters.");
            
            return passwordIsOK;
        }

        //This function was taken from
        //stackoverflow.com/questions/14634477/how-to-check-if-string-has-more-than-two-repeating-characters
        static public bool IsOK(string s)
        {
            if (s.Length < 3) return true;

            return !s.Where((c, i) => i >= 2 && s[i - 1] == c && s[i - 2] == c).Any();
        }
    }
}
