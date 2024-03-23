using LeetCode.LeetCode_Problems;
using System.Xml.Linq;

int[] myNum = { 10, 20, 30, 40 };
ListNode nodeMaker(int[] arr){
    ListNode head =  new(arr[0]);
    ListNode tempNode = head;
    for (int i = 1; i < arr.Length; i++)
    {
        ListNode _node = new(arr[i]);
        tempNode.next = _node;
        tempNode=tempNode.next;
    }
    return head;
}
ListNode node=nodeMaker(myNum);
while (node != null)
{
    Console.WriteLine(node.val);
    node = node.next;

}


