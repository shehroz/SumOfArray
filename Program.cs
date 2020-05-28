using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 100, 10, 1 ,3344};
            Console.WriteLine("Sum of arr:[" + SumofArray(arr) + "]");
            Console.ReadKey();

        }

        //public static string SumofStrings(string s1, string s2)
        //{
        //    int numOfZero = 0;
        //    int carry = 0, rem = 0;
        //    string sum = "";

        //    int num1 = Convert.ToInt32(s1);
        //    int num2 = Convert.ToInt32(s2);


        //    if (num1 < 0 && num2 < 0)
        //    {
        //        s1 = s1.Substring(1, s1.Length - 1);
        //        s2 = s2.Substring(1, s2.Length - 1);
        //    }
        //    else if (num1 < 0)
        //        s1 = s1.Substring(1, s1.Length - 1);
        //    else if (num2 < 0)
        //        s2 = s2.Substring(1, s2.Length - 1);

        //    if (s1.Length > s2.Length)
        //    {
        //        numOfZero = s1.Length - s2.Length;
        //        for (int i = 0; i < numOfZero; i++)
        //            s2 = "0" + s2;
        //    }
        //    else
        //    {
        //        numOfZero = s2.Length - s1.Length;
        //        for (int i = 0; i < numOfZero; i++)
        //        {
        //            s1 = "0" + s1;
        //        }
        //    }
        //    if (num1 > 0 && num2 > 0 || num1 < 0 && num2 < 0)
        //    {
        //        for (int i = s1.Length - 1; i >= 0; i--)
        //        {
        //            carry += ToInt(s1[i]) + ToInt(s2[i]);
        //            if (carry < 10)
        //            {
        //                sum = carry.ToString() + sum;
        //                carry = 0;
        //            }
        //            else
        //            {
        //                sum = Convert.ToString(carry % 10) + sum;
        //                carry = carry / 10;
        //            }

        //        }
        //        if (carry == 1)
        //            sum = carry.ToString() + sum;
        //    }
        //    else if (num1 < 0 && num2 > 0 || num2 < 0 && num1 > 0)
        //    {
        //        if (num1 < 0 && num2 > 0)
        //        {
        //            num1 *= (-1);
        //            if (num1 > num2)
        //            {
        //                for (int i = s1.Length - 1; i >= 0; i--)
        //                {
        //                    if (carry == 0)
        //                    {
        //                        if (ToInt(s1[i]) >= ToInt(s2[i]))
        //                        {
        //                            rem = ToInt(s1[i]) - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            rem = (10 + ToInt(s1[i])) - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 1;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        int numCarryAdded = ToInt(s1[i]) - 1;
        //                        if (numCarryAdded >= ToInt(s2[i]))
        //                        {
        //                            rem = numCarryAdded - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            if (i != 0)
        //                            {
        //                                rem = (10 + numCarryAdded) - ToInt(s2[i]);
        //                            }
        //                            else
        //                            {
        //                                rem = numCarryAdded - ToInt(s2[i]);
        //                            }
        //                            if (rem != 0)
        //                            {
        //                                sum = rem.ToString() + sum;
        //                                carry = 1;
        //                            }
        //                        }

        //                    }
        //                }
        //                sum = "-" + sum;
        //            }
        //            else
        //            {

        //                for (int i = s1.Length - 1; i >= 0; i--)
        //                {
        //                    if (carry == 0)
        //                    {
        //                        if (ToInt(s2[i]) >= ToInt(s1[i]))
        //                        {
        //                            rem = ToInt(s2[i]) - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            rem = (10 + ToInt(s2[i])) - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 1;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        int numCarryAdded = ToInt(s2[i]) - 1;
        //                        if (numCarryAdded >= ToInt(s1[i]))
        //                        {
        //                            rem = numCarryAdded - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            if (i != 0)
        //                            {
        //                                rem = (10 + numCarryAdded) - ToInt(s1[i]);
        //                            }
        //                            else
        //                            {
        //                                rem = numCarryAdded - ToInt(s1[i]);
        //                            }
        //                            if (rem != 0)
        //                            {
        //                                sum = rem.ToString() + sum;
        //                                carry = 1;
        //                            }
        //                        }

        //                    }
        //                }

        //            }
        //        }
        //        else if (num1 > 0 && num2 < 0)
        //        {
        //            num2 *= (-1);
        //            if (num2 > num1)
        //            {
        //                for (int i = s1.Length - 1; i >= 0; i--)
        //                {
        //                    if (carry == 0)
        //                    {
        //                        if (ToInt(s2[i]) >= ToInt(s1[i]))
        //                        {
        //                            rem = ToInt(s2[i]) - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            rem = (10 + ToInt(s2[i])) - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 1;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        int numCarryAdded = ToInt(s2[i]) - 1;
        //                        if (numCarryAdded >= ToInt(s1[i]))
        //                        {
        //                            rem = numCarryAdded - ToInt(s1[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            if (i != 0)
        //                            {
        //                                rem = (10 + numCarryAdded) - ToInt(s1[i]);
        //                            }
        //                            else
        //                            {
        //                                rem = numCarryAdded - ToInt(s1[i]);
        //                            }
        //                            if (rem != 0)
        //                            {
        //                                sum = rem.ToString() + sum;
        //                                carry = 1;
        //                            }
        //                        }

        //                    }
        //                }
        //                sum = "-" + sum;
        //            }
        //            else
        //            {

        //                for (int i = s1.Length - 1; i >= 0; i--)
        //                {
        //                    if (carry == 0)
        //                    {
        //                        if (ToInt(s1[i]) >= ToInt(s2[i]))
        //                        {
        //                            rem = ToInt(s1[i]) - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            rem = (10 + ToInt(s1[i])) - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 1;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        int numCarryAdded = ToInt(s1[i]) - 1;
        //                        if (numCarryAdded >= ToInt(s2[i]))
        //                        {
        //                            rem = numCarryAdded - ToInt(s2[i]);
        //                            sum = rem.ToString() + sum;
        //                            carry = 0;
        //                        }
        //                        else
        //                        {
        //                            if (i != 0)
        //                            {
        //                                rem = (10 + numCarryAdded) - ToInt(s2[i]);
        //                            }
        //                            else
        //                            {
        //                                rem = numCarryAdded - ToInt(s2[i]);
        //                            }
        //                            if (rem != 0)
        //                            {
        //                                sum = rem.ToString() + sum;
        //                                carry = 1;
        //                            }
        //                        }

        //                    }
        //                }

        //            }
        //        }
        //    }

        //    if (num1 < 0 && num2 < 0)
        //        sum = "-" + sum;

        //    return sum;
        //}
        public static int ToInt(char c)
        {
            return (int)(c - '0');
        }
        public static string SumofArray(int[] arr)
        {
            string sum = arr[0].ToString();
            for (int i = 1; i < arr.Length; i++)
            {
                sum = SumofStrings(sum, arr[i].ToString());
            }
            return sum;
        }
        public static string SumofStrings(string s1, string s2)
        {
            string Result = "";
            if (s1.Length == 0 || s1.Trim('0') == "")
                return s2;
            else if (s2.Length == 0 || s2.Trim('0') == "")
                return s1;
            else if (s1.Length == 0 && s2.Length == 0)
                return "0";
            else if (s1.Length > s2.Length)
            {
                int lenDiff = s1.Length - s2.Length;
                for (int i = 0; i < lenDiff; i++)
                {
                    s2 = "0" + s2;
                }
            }
            else if (s2.Length > s1.Length)
            {
                int lenDiff = s2.Length - s1.Length;
                for (int i = 0; i < lenDiff; i++)
                {
                    s1 = "0" + s1;
                }
            }
            int carry = 0;
            int len = s1.Length - 1;

            for (int i = len; i >= 0; i--)
            {
                int total = ToInt(s1[i]) + ToInt(s2[i]) + carry;
                Result = (Convert.ToString(total % 10)) + Result;
                carry = total / 10;
            }
            if (carry != 0)
                Result = carry.ToString() + Result;
            return Result;
        }
    }
}
