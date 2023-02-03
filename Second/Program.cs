using Microsoft.VisualBasic.FileIO;
using System;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Verilmish sozun bosluga gore sayi

            //string words = Console.ReadLine();
            //Console.WriteLine(Arr(words));

            #endregion

            #region Verilmish sozde reqemin yoxlanilmasi

            //string word = Console.ReadLine();
            //Console.WriteLine(CheckDigit(word));

            #endregion

            #region Verimish sozde boyuk ve ya kicik herfin tapilmasi

            //string word = Console.ReadLine();
            //Console.WriteLine(HasLower(word));

            #endregion

            #region Verilmish sozde charin sayinin tapilmasi

            //Console.WriteLine("Deyer daxil edin:");
            //string word = Console.ReadLine();
            //Console.WriteLine("Yoxlamag istediyiniz herfi daxil edin:");
            //string cr = Console.ReadLine();
            //char a = Convert.ToChar(cr);
            //Console.WriteLine(FindCharCount(word, a));

            #endregion

            #region Verilmish sozu tersine yazmag

            //Console.WriteLine("Deyer daxil edin:");
            //string word = Console.ReadLine();
            //Console.WriteLine(ReverseStr(word));

            #endregion

            #region Contact proqrami

            string[] contacts = { "Emil-0553543469" };

            string option;

            do
            {
                Console.WriteLine("\n1. Shexs yarat");
                Console.WriteLine("2. Shexslere bax");
                Console.WriteLine("3. Shexsler uzre axtaris et");
                Console.WriteLine("4. Nomrelere gore axtaris et");
                Console.WriteLine("5. Bakcell nomrelere bax");
                Console.WriteLine("0. Menu");

                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Shexsin adini ve nomresi:");
                        string newPerson = Console.ReadLine();
                        Array.Resize(ref contacts, contacts.Length + 1);
                        contacts[contacts.Length - 1] = newPerson;
                        break;

                    case "2":
                        for (int i = 0; i < contacts.Length; i++)
                        {
                            Console.WriteLine(contacts[i]);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Shexsin adinin her hansi herfini qeyd edin:");
                        string searchPerson = Console.ReadLine();
                        bool isExist = false;

                        for (int i = 0; i < contacts.Length; i++)
                        {
                            if (contacts[i].ToLower().Contains(searchPerson) || contacts[i].ToUpper().Contains(searchPerson))
                            {
                                Console.WriteLine(contacts[i]);
                                isExist = true;
                            }
                        }

                        if (isExist)
                        {
                            Console.WriteLine("Bele bir shexs yoxdur!");
                        }

                        break;

                    case "4":
                        Console.WriteLine("Nomrenin her hansi bir reqemini daxil edin:");
                    PhoneNumber: string phoneNumberStr = Console.ReadLine();
                        int phoneNumber;

                        bool isPhoneNumber = int.TryParse(phoneNumberStr, out phoneNumber);

                        if (isPhoneNumber)
                        {
                            for (int i = 0; i < contacts.Length; i++)
                            {
                                if (contacts[i].Contains(phoneNumber.ToString()))
                                {
                                    Console.WriteLine(contacts[i]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nomrenin formatini duzgun daxil ele:");
                            goto PhoneNumber;
                        }

                        break;

                    case "5":
                        Console.WriteLine("Bakcell nomrelere");
                        break;

                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;

                    default:
                        Console.WriteLine("Secim sehvdir, yeniden daxil edin");
                        break;
                }
            }
            while (option != "0");

            #endregion
        }
        static int Arr(string words)
        {
            var arr = words.Split(' ');
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
            }
            return count;
        }

        static bool CheckDigit(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;

        }

        static bool HasLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    return true;
                }
            }

            return false;
        }

        static int FindCharCount(string word, char a)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == a)
                {
                    count++;
                }
            }

            return count;
        }

        static string ReverseStr(string word)
        {
            string reverseStr = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseStr += word[i];
            }

            return reverseStr;
        }
    }
}
