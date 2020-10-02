using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCollection;

namespace Lab1_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n An example of using my collection \n\n            Tree int \n");

            BinareTree<int> binareTree = new BinareTree<int>();

            binareTree.Ev += Display;
                                                        // Додавання елементів у бінарне дерево

            binareTree.Add(8);
            binareTree.Add(4);
            binareTree.Add(10);
            binareTree.Add(2);
            binareTree.Add(6);
            binareTree.Add(3);
            binareTree.Add(7);
                                                          //Кількість елементів в дереві
            Console.WriteLine("====================================================================");
            int amount = binareTree.Count;
            Console.WriteLine("The number of elements in the binary tree = " + amount);

                                                          //Мінімальне та максимальне значення в дереві
            Console.WriteLine("====================================================================");
            int max = binareTree.Max;
            int min = binareTree.Min;
            Console.WriteLine("The maximum value in the tree = " + max);
            Console.WriteLine("The minimum value in the tree = " + min);


                                                          //Перевірка на наявність вузла в дереві
            Console.WriteLine("====================================================================");
           
            binareTree.Contains(4);
            binareTree.Contains(1);

                                                          //Обхід дерева двома способами
            Console.WriteLine("\n\n====================================================================");
            Console.WriteLine("Inorder output");

            foreach (int temp1 in binareTree)
            {
                Console.WriteLine(temp1 + " ");
            }

            //Console.WriteLine("========================================\n");

            Console.WriteLine("Postorder output");

            foreach (int temp2 in binareTree.Postorder())
            {
                Console.WriteLine(temp2 + " ");
            }



            Console.WriteLine("\n\n                       Tree string \n");


            BinareTree<string> binareTreestring = new BinareTree<string>();

            binareTreestring.Ev += Display;
                                                             // Додавання елементів у бінарне дерево

            binareTreestring.Add("k");
            binareTreestring.Add("p");
            binareTreestring.Add("i");
            binareTreestring.Add("s");
            
                                                             //Кількість елементів в дереві
            Console.WriteLine("====================================================================");
            int amount2 = binareTreestring.Count;
            Console.WriteLine("The number of elements in the binary tree = " + amount2);


                                                              //Перевірка на наявність вузла в дереві
            Console.WriteLine("====================================================================");
            bool node3 = binareTreestring.Contains("ba");
            bool node4 = binareTreestring.Contains("s");
            Console.WriteLine("The value 'ba' is contained in the tree?" + node3);
            Console.WriteLine("The value 's' is contained in the tree?" + node4);

            Console.ReadKey();
        }

        private static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
