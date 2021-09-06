using System;
using System.Collections;

namespace AddArrayListInExistingArrayList
{
    class ArrListDemo
    {
        int value = 0;
        internal void InsertRange(ArrayList list1, ArrayList list2,int value)
        {
            list1.InsertRange(value, list2);
        }
        internal bool Check(ArrayList list1, int value)
        {
            return list1.Contains(value);
        }
        class Program
        {

            static void Main(string[] args)
            {
                int value=0;
                ArrayList list1 = new ArrayList() { 100, 200, 600 };

                ArrayList list2 = new ArrayList() { 300, 400, 500 };

                
                Console.WriteLine("ArrayList Elements");

                for (int i = 0; i < list1.Count; i++)
                    Console.WriteLine(list1[i]);
                list1.AddRange(list2);
                new ArrListDemo().InsertRange(list1, list2, value);

            }
        }
    }

}