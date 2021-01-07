using System;
using System.Collections.Generic;
using System.Text;
namespace VSCode_test {
    public static class Principal {
        static void Main(String[] args) {
            Console.Clear(); 
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            
            Something[] obj = new Something[10];

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new Something(new Random().NextDouble(),
                new Random().Next(0,256).ToString(), null);
            }

            var s = new List<int> {0,1,2};
            Console.WriteLine(obj[0] + "\n" + obj[1]);

            var fibonnacciList = new List<int> {1,1};
            fibonnacci(1,1,fibonnacciList);

            /*foreach(int i in fibonnacciList) {
                Console.WriteLine(i);
            }
            try {
                var a = new StringBuilder();
                //Console.ForegroundColor = ConsoleColor.Cyan;
                
            }
            catch(Exception) {
                Console.WriteLine("%d");
            }*/

            System.Console.WriteLine("\nIEnumerator");
            MyEnumerable<Something> myEnumerableList = new MyEnumerable<Something>();
            myEnumerableList.list.AddRange(obj);
            myEnumerableList.list.Sort( delegate(Something p1, Something p2) {
                return p2.CompareTo(p1);
            });

            System.Console.WriteLine("\nForeach");
            foreach (var item in myEnumerableList)
            {
                System.Console.WriteLine(item);
            }
            myEnumerableList.list.Sort(
                delegate(Something p1, Something p2) {
                    int compareDate = p1.someNumber.CompareTo(p2.someNumber);
                    if (compareDate == 0) {
                        compareDate = p1.someText.CompareTo(p2.someText);
                    }
                    return compareDate;
                }
            );
            System.Console.WriteLine("\nFor");
            for (int i = 0; i < myEnumerableList.list.Count; i++)
            {
                System.Console.WriteLine(myEnumerableList[i] + "\n");
            }
        }

        static void fibonnacci(int golden, int silver, List<int> f) {
            if(f.Count != 20) {
                f.Add(golden+silver);
                fibonnacci(f[f.Count-1], f[f.Count-2], f);
            }
        }
    }
}