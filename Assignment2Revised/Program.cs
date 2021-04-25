using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Enter a set of numbers: ");
            int[] nums = {6, 5, 4, 7, 9, 6};
            int n = Convert.ToInt32(Console.ReadLine());
            Shuffle(nums, n);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Enter a set of numbers: ");
            int[] nums2 = { 0, 1, 2, 3, 10};
            MoveZeros(nums2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Enter an array of integers: ");
            int[] nums3 = { 1, 2, 2, 3, 2, 4};
            NumIdenticalPairs(nums3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Give an array of integers: ");
            int[] nums4 = { 1, 2, 1, 3, 4, 1 };
            int target = 0;
            TwoSum(nums4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Give a string: ");
            string s = Console.ReadLine();
            int[] indices = { 1, 3, 6, 0, 2, 1, 7, 4 };
            RestoreString(s, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s1 = Console.ReadLine();
            string t = Console.ReadLine();
            IsIsomorphic(s, t);
            if (IsIsomorphic(s, t))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();
            Console.ReadKey();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();
            Console.ReadKey();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            IsHappy(n8);
            if (IsHappy(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();
            Console.ReadKey();

            //Question 9
            Console.WriteLine("Question 9");
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            MaxProfit(prices);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            ClimbStairs(n10);
            Console.ReadKey();

            //Question 1
            static void Shuffle(int[] nums, int n)
            {
                try
                {
                    int[] answer = new int[2 * n];//define a new array
                    int k = 0, m = n;
                    for (int i = 0; i < 2 * n; i++)//control i in the new array
                    {

                        if (i % 2 == 0)
                            answer[i] = nums[k++];//if i is even, then put in the first part of the array
                        else
                            answer[i] = nums[m++];//if it is odd, then put it in the place starting from n
                    }



                    for (int i = 0; i < 2 * n; i++)
                        Console.Write(answer[i] + " ");//return all the numbers in the array
                    Console.ReadKey();

                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 2:
            static void MoveZeros(int[] nums2)
            {
                try
                {
                    for (int i = 0; i < nums2.Length; i++)
                    {
                        nums2[i] = int.Parse(Console.ReadLine());
                    }

                    static void MoveZeros(int[] nums2)
                    {
                        if (nums2 == null || nums2.Length <= 1)
                            return;

                        int curr = 0;
                        int next = 1;

                        while (next <= nums2.Length - 1)
                        {
                            if (nums2[curr] == 0)
                            {
                                if (nums2[next] == 0)
                                {
                                    next++;
                                    continue;
                                }
                                else
                                {
                                    nums2[curr] = nums2[next];
                                    nums2[next] = 0;
                                }
                            }
                            curr++;
                            next++;
                        }
                    }
                    MoveZeros(nums2);
                    Console.WriteLine(nums2);

                }
                catch (Exception)
                {

                    throw;
                }
            }


            //Question 3
            static void NumIdenticalPairs(int[] nums3)
            {
                try
                {
                    var dict = new Dictionary<int, int>();
                    for (int i = 0; i < nums3.Length; i++)
                    {
                        if (dict.ContainsKey(nums3[i]))
                        {
                            dict[nums3[i]] += 1;
                        }
                        else
                        {
                            dict[nums3[i]] = 1;
                        }
                    }

                    int k = 0;
                    foreach (var keyValuePair in dict)
                    {
                        if (keyValuePair.Value == 1) continue;
                        k += keyValuePair.Value * (keyValuePair.Value - 1) / 2;
                    }

                    Console.WriteLine(dict);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 4:
            static void TwoSum(int[] nums4, int target)
            {
                try
                {
                    var dict = new Dictionary<int, int>();//create a new dictionary

                    for (int i = 0; i < nums4.Length; i++)
                    {
                        if (dict.ContainsKey(target - nums4[i])) //check if the dictionary contains the key equals target minus nums[i]
                        {
                            Console.Write("[{0},{1}]", dict[target - nums4[i]], i);//print out result
                        }
                        else if (!dict.ContainsKey(nums4[i])) //if it doesn't contain the key then record the value into the dictionary
                        {
                            dict.Add(nums4[i], i);
                        }
                    }

                    return;
                }
                
                catch (Exception)
                {

                    throw;
                }

            }

            //Question 5:
            static void RestoreString(string s, int[] indices)
            {
                try
                {
                    char[] cArr = new char[s.Length];

                    for (int i = 0; i < s.Length; i++)
                    {
                        cArr[indices[i]] = s[i];
                    }

                    Console.WriteLine(cArr);

                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 6
            static bool IsIsomorphic(string s1, string t)
            {
                try
                {
                    int index = 0;
                    Hashtable hashS = new Hashtable();
                    Hashtable hashT = new Hashtable();

                    while (index <= s1.Length - 1)
                    {
                        if (hashS.ContainsKey(s1[index]) != hashT.ContainsKey(t[index]) ||
                            (hashS.ContainsKey(s1[index]) && hashT.ContainsKey(t[index]) && (int)hashS[s1[index]] != (int)hashT[t[index]]))
                            return false;

                        if (!hashS.ContainsKey(s1[index]))
                        {
                            hashS.Add(s1[index], index);
                            hashT.Add(t[index], index);
                        }

                        index++;
                    }

                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 7
            static void HighFive(int[,] items)
            {
                try
                {
                    //write your code here.

                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 8
            static bool IsHappy(int n8)
            {
                try
                {
                    HashSet<int> seen = new HashSet<int>();
                    while (n8 != 1)
                    {
                        if (seen.Contains(n8))
                            return false;
                        seen.Add(n8);
                        int newNum = 0;
                        while (n8 > 0)
                        {
                            newNum += (int)Math.Pow(n8 % 10, 2);
                            n8 /= 10;
                        }
                        n8 = newNum;
                    }
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 9
            static int MaxProfit(int[] prices)
            {
                try
                {
                    var n = prices.Length;
                    if (n == 0) return 0;
                    var globalMaxProfit = 0;
                    var globalMin = prices[0];
                    for (int i = 1; i < n; i++)
                    {
                        var curPrice = prices[i];
                        var localMaxProfit = Math.Max(0, curPrice - globalMin);
                        globalMaxProfit = Math.Max(localMaxProfit, globalMaxProfit);
                        globalMin = Math.Min(globalMin, curPrice);
                    }

                    return globalMaxProfit;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Question 10
            static void ClimbStairs(int n10)
            {
                try
                {
                    int first = 1;
                    int second = 1;
                    while (n10-- > 0)
                    {
                        int tmp = first;
                        first = second;//replace the value
                        second = tmp + second;//replace second
                    }
                    Console.WriteLine(first);//print out the value

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}