using System;
using System.Collections.Generic;
using System.Linq;

namespace ParadigmaTechTest.Task2
{
    public class TreeNode
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;
        public TreeNode(int value) => Value = value;
    }

    public static class TreeBuilder
    {
        public static TreeNode Build(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be null or empty.", nameof(arr));

            int max = arr.Max();
            int rootIndex = Array.IndexOf(arr, max);
            var root = new TreeNode(max);

            var leftSlice = arr.Take(rootIndex).OrderByDescending(x => x);
            TreeNode? cursor = root;
            foreach (var v in leftSlice)
            {
                var node = new TreeNode(v);
                cursor!.Left = node;
                cursor = node;
            }

            var rightSlice = arr.Skip(rootIndex + 1).OrderByDescending(x => x);
            cursor = root;
            foreach (var v in rightSlice)
            {
                var node = new TreeNode(v);
                cursor!.Right = node;
                cursor = node;
            }

            return root;
        }
    }

    public static class Printer
    {
        public static void Print(TreeNode? node, string indent = "", bool isLeft = true)
        {
            if (node == null) return;

            Console.WriteLine(indent + (isLeft ? "├─" : "└─") + node.Value);
            var nextIndent = indent + (isLeft ? "│  " : "   ");
            if (node.Left != null) Print(node.Left, nextIndent, true);
            if (node.Right != null) Print(node.Right, nextIndent, false);
        }

        public static IEnumerable<int> Preorder(TreeNode? n)
        {
            if (n == null) yield break;
            yield return n.Value;
            foreach (var x in Preorder(n.Left)) yield return x;
            foreach (var x in Preorder(n.Right)) yield return x;
        }
    }

    public class Tarefa2
    {
        public static void Main()
        {
            var arr1 = new[] { 3, 2, 1, 6, 0, 5 };
            var tree1 = TreeBuilder.Build(arr1);
            Console.WriteLine("Cenário 1:");
            Printer.Print(tree1);
            Console.WriteLine("Preorder: " + string.Join(", ", Printer.Preorder(tree1)));
            Console.WriteLine();

            var arr2 = new[] { 7, 5, 13, 9, 1, 6, 4 };
            var tree2 = TreeBuilder.Build(arr2);
            Console.WriteLine("Cenário 2:");
            Printer.Print(tree2);
            Console.WriteLine("Preorder: " + string.Join(", ", Printer.Preorder(tree2)));
        }
    }
}
