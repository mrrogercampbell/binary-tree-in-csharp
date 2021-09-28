using System;
namespace binaryTree
{
    public class BinaryTree
    {
        private int[] _orderedList;

        public Node RootNode
        { get; set;}


        public BinaryTree(int[] orderedList)
        {
            this._orderedList = orderedList;
        }

        private void ConvertOrderedListToTree()
        {
            
        }
        //private void ConvertOrderedListToTree()
        //{
        //    this.SplitListInHalf = this._orderedList;
        //    int firstItemInList = this._orderedList[0];

        //    int[] lowerBoundArray; //1, 2, 3, 4, 8,
        //    int[] upperBoundArray; //10, 14, 18, 20, 30

        //    Node rootNode = new Node(firstItemInList);

        //    Console.WriteLine(rootNode.Value);
        //    Console.WriteLine(rootNode);
        //}

        //private void SplitListInHalf()
        //{

        //int orderListLength = orderedList.Length;
        //int upperBoundStartSlicePoint = (orderListLength / 2) + 1;
        //int amountOfIndicesToSlice = orderListLength - upperBoundStartSlicePoint;


        //var lowerBoundList = new ArraySegment<int>(orderedList, upperBoundStartSlicePoint, amountOfIndicesToSlice);

        //Console.WriteLine(lowerBoundList);

        //    foreach (var item in lowerBoundList)
        //    {
        //        Console.WriteLine(item); 
        //    }
    //    Console.WriteLine(orderListLength / 2);

    //}

}
}
