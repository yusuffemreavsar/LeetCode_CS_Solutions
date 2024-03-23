
namespace LeetCode.LeetCode_Problems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

     
    }
    
    public class Problem_21
    {
        List<int> mergeList = new List<int>();
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
           while (list1 !=null)
            {
               list1=list1.next;
                if (list1 == null)
                {
                    list1.next = list2;
                }
            }


            return list1;
        }
    }
 
}
