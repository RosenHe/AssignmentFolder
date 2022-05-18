using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class _02UnderstandingTypes
    {
        public void numberType()
        {
            String[] dataType = {"sbtye", "byte", "short", "ushort",
                "int", "uint", "long", "ulong", "float", "double", "decimal" };
            String[] dataSize = {"Signed 8-bit integer", "Unsigned 8-bit integer",
            "Signed 16-bit integer","Unsigned 16-bit integer", "Signed 32-bit integer",
            "Unsigned 32-bit integer", "Signed 64-bit integer", "Unsigned 64-bit integer",
            "4 bytes", "8 bytes","16 bytes"};
            String[] dataRange = {"-128 to 127", "0 to 255", "-32,768 to 32,767",
                "0 to 65,535", "-2,147,483,648 to 2,147,483,647", "0 to 4,294,967,295",
            "-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807", "0 to 18,446,744,073,709,551,615",
            "±1.5 x 10−45 to ±3.4 x 1038", "±5.0 × 10−324 to ±1.7 × 10308", "±1.0 x 10-28 to ±7.9228 x 1028"};
            Console.WriteLine("{0,-10} {1,-40} {2,-10}\n", "Data Type", "Data Size", "Range");
            for (int ctr = 0; ctr < dataType.Length; ctr++)
            {
                Console.WriteLine("{0,-10} {1,-40:N1} {2,-10:N1}", dataType[ctr], dataSize[ctr], dataRange[ctr]);


            }


        }
        public void centuriesCalculator(String num)
        {
            String year = cenCalHelper(num, "100");
            String day = cenCalHelper(num, "36524");
            String hour = cenCalHelper(num, "876576");
            String minute = cenCalHelper(num, "52594560");
            String second = cenCalHelper(num, "3155673600");
            String milliseconds = cenCalHelper(num, "3155673600000");
            String microseconds = cenCalHelper(num, "3155673600000000");
            String nanoseconds = cenCalHelper(num, "3155673600000000000");
            Console.WriteLine(num + " centuries = " +
                year + " years = " + day + " days = " + hour + " hours = " +
                minute + " minutes = " + second + " second = " +
                milliseconds + " milliseconds = " + microseconds + " microseconds = " +
                nanoseconds + " nanoseconds.");
        }
        public string cenCalHelper(String num1, String num2)
        {
            int m = num1.Length;
            int n = num2.Length;
            int[] res = new int[m + n];
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int p1 = i + j;
                    int p2 = i + j + 1;
                    int sum = mul + res[p2];
                    res[p2] = sum % 10;
                    res[p1] += sum / 10;
                }
            }
            int k = 0;
            while (k < res.Length && res[k] == 0)
            {
                k++;
            }
            StringBuilder sb = new StringBuilder();
            for (; k < res.Length; k++)
            {
                sb.Append(res[k]);
            }
            String ans = sb.ToString();
            return ans.Length == 0 ? "0" : ans;
        }
        public void FizzBuzz(string num)
        {
            int n = Convert.ToInt32(num);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void paramid(int layer)
        {
            for (int i = 1; i <= layer; i++)
            {
                for (int space = 1; space <= (layer - i); space++)
                    Console.Write(" ");
                for (int num = 1; num <= i; num++)
                    Console.Write("*");
                for (int num = (i - 1); num >= 1; num--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public void generateNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);//(Including min and excludes max)
            String a = Console.ReadLine();
            int guessedNumber = int.Parse(a);
            if (randomNumber == guessedNumber)
            {
                Console.WriteLine("Bingo, you guessed the right number.");
            }
            else if (guessedNumber > 3 || guessedNumber < 1)
            {
                Console.WriteLine("The valid guesses are less or eqaul to 1 and more or equal to 3.");
            }
            else if (randomNumber < guessedNumber)
            {
                Console.WriteLine("You have guessed a bigger number.");
            }
            else if (randomNumber > guessedNumber)
            {
                Console.WriteLine("You have guessed a smaller number.");
            }
        }
        public void greetingTime()
        {
            DateTime dt = DateTime.Now;
            if (dt.Hour < 6)
            {
                Console.WriteLine("Good Night.");
            }
            else if (dt.Hour >= 6 && dt.Hour < 12)
            {
                Console.WriteLine("Good Morning.");
            }
            else if (dt.Hour >= 12 && dt.Hour < 18)
            {
                Console.WriteLine("Good Afternoon.");
            }
            else if (dt.Hour >= 18)
            {
                Console.WriteLine("Good Evening.");
            }
        }
        public void countingNumber()
        {
            for (int i = 0; i <= 24; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= 24; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= 24; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= 24; i += 4)
            {
                Console.Write(i + " ");
            }
        }
        public void calculateDays()
        {
            DateTime dt = DateTime.Now;
            var yr = dt.AddYears(-1);
            Console.WriteLine(yr);
            Console.WriteLine(yr.DayOfYear);
        }
        //Date.prototype.isLeapYear = function()
        //{
        //    var year = this.getFullYear();
        //    if ((year & 3) != 0) return false;
        //    return ((year % 100) != 0 || (year % 400) == 0);
        //};

        public void copyArray()
        {
            int[] a = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }
        public void toDoList()
        {
            List<string> map = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or ! to clear)):");
                String order = Console.ReadLine();
                if (order.Contains("+"))
                {
                    String item = order.Substring(2);
                    map.Add(item);
                }
                else if (order.Contains("-"))
                {
                    String item = order.Substring(2);
                    map.Remove(item);

                }
                else if (order.Contains("!"))
                {
                    map.Clear();
                }

                for(int i = 0; i < map.Count; i++)
                {
                    Console.Write((map[i] + " ") + " ");
                }
                Console.WriteLine();
            }
        }

        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for(int i = startNum; i <= endNum; i++)
            {
                if (i == 1 || i == 0) continue;
                Boolean p = true;
                for(int j = 2; j <= i / 2; ++j)
                {
                    if(i % j == 0)
                    {
                        p = false;
                        break;
                    }
                }
                if (p)
                {
                    primes.Add(i);
                }
                
            }

            int[] res = primes.ToArray();

            return res;
        }

        public void rotateArrayAndSum(int[] array, int rotate)
        {
            int n = array.Length;
            int[] b = new int[n];
            for(int i = rotate+1; i > 1; i--)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(array[(j + i) % n] + " ");
                    b[j] += array[(j + i) % n];
                }
                Console.WriteLine();

            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(b[i] +" ");
            }
            Console.WriteLine();
        }
        
        public void findTheLongestEqualSubsequence(String input)
        {
            int len = 1;
            int start = 0;
            int maxLen = -1;
            int maxStart = 0;
            for(int i =0; i < input.Length-1; i++)
            {
                if(input[i] == input[i + 1])
                {
                    len++;
                    if(len > maxLen)
                    {
                        maxLen = len;
                        maxStart = start;
                    }
                }
                else
                {
                    len = 1;
                    start = i+1;
                }
            }
            Console.WriteLine(input.Substring(maxStart, maxLen));
        }
        public void findMostFrequentNumber(int[] input)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int max = -1;
            int maxNum = -1;
            for(int i = 0; i < input.Length; i++)
            {
                if (!d.ContainsKey(input[i]))
                {
                    d.Add(input[i], 1);
                }
                else
                {
                    d[input[i]]++;
                    
                }
                if (d[input[i]] > max)
                {
                    max = d[input[i]];
                    maxNum = input[i];
                }
            }
            Console.WriteLine(maxNum);
        }
        public void reverseLetter()
        {
            String input = Console.ReadLine();
            for(int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
            char[] ch = input.ToCharArray();
            for(int i = 0; i < ch.Length/2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[ch.Length-i-1];
                ch[ch.Length - i-1] = temp;
            }
            for(int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]);
            }
        }

        public void puncAndSpaces(String input)
        {
            //First String.tocharArray();
            //Combine those character without separators, leave the separators alone. So that we can have separator's index.
            char[] ch = input.ToCharArray();
            List<String> list = new List<String>();
            StringBuilder sb = new StringBuilder();
            List<int> list2 = new List<int>(); //store the separator's index. So that we dont have to check the index again.
            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                else if (ch[i] == '.' || ch[i] == ':' || ch[i] == ';' || ch[i] == '=' || ch[i] == '(' || ch[i] == ')' || ch[i] == '&' || ch[i] == '[' ||
                    ch[i] == ']' || ch[i] == '\"' || ch[i] == '\'' || ch[i] == '\\' || ch[i] == '/' || ch[i] == '?' || ch[i] == '!' || ch[i] == ' ' || ch[i] ==',')
                {
                    list2.Add(list.Count+1);
                    list.Add(sb.ToString());
                    list.Add(ch[i].ToString());
                    sb.Clear();

                }
                else
                {
                    sb.Append(ch[i]);
                }
                
            }
            sb.Clear();
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
            int left = 0; 
            int right = list.Count - 1; // skip the last separator.
            while(left < right)
            {
                while(list2.Contains(left)) left++;
                while(list2.Contains(right)) right--;
                String temp = list[left];
                list[left++] = list[right];
                list[right--] = temp;

            }
            for (int i = 0; i < list.Count; i++)
            {
                if(list2.Contains(i+1)) sb.Append(list[i]);
                else
                    sb.Append(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sb.ToString());
        }
        public void palindromes(String input)
        {
            //Because we dont need any non-Letter words.  Char.isLetter(String, index) can check the current char is letter or not.
            
            //separate words from String input.
            List<String> list = new List<String>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                    sb.Append(input[i]);
                else
                {
                    if(sb.Length > 0)
                    {
                        list.Add(sb.ToString());
                        sb.Clear();
                    }
                }
            }
            if(sb.Length > 0) list.Add(sb.ToString());

            //Now check are they palindromes.
            //Make sure they are not duplicates. may use HashSet.
            //And we need it sorted. so that we may use SortedSet
            SortedSet<string> res = new SortedSet<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (checkPalind(list[i]))
                {
                    res.Add(list[i]);
                }
            }
            //Print all the unqiue palindormes, no dulicates and sorted.
            // The sortedSet is not list construct. so that we can use indexing "res[i]"
            //use for each
            //check when it is the last element not print common after.
            int r = 0;
            foreach(string s in res)
            {
                if(r == res.Count - 1)
                {
                    Console.Write(s);
                    break;
                }
                else
                {
                    Console.Write(s + ", ");
                }
                r++;
            }

        }
        public bool checkPalind(String input)
        {
            int left;
            int right;
            int n = input.Length;
            if(n % 2 == 0)//even length
            {
                left = n / 2 - 1;
                right = n / 2;
                while(left >= 0 && right < n)
                {
                    if (input[left] == input[right])
                    {
                        left--;
                        right++;
                    }
                    else
                        return false; // they are not equal. return false, they are not palindromes.
                }
            }
            else //odd length string.asdsa length = 5. mid = 5/2 = 2 => left = n/2-1, right = n/2+1;
            {
                left = n / 2 - 1;
                right = n / 2 + 1;
                while(left >= 0 && right < n)
                {
                    if(input[left] == input[right])
                    {
                        left--;
                        right++;
                    }else
                        return false;
                }
            }

            return true;
        }
    }
}
