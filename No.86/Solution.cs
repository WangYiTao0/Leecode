//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode Partition(ListNode head, int x)
    {
        
        ListNode small = new ListNode(0);
        Console.WriteLine($"small HashCode { small.GetHashCode()}");
        ListNode smallHead = small; // smallHead 引用了 small 的地址
        Console.WriteLine($"smallHead HashCode { smallHead.GetHashCode()}");
        ListNode big = new ListNode(0);
        Console.WriteLine($"big HashCode { big.GetHashCode()}");
        ListNode bigHead = big; // bigHead 引用了 big 的地址
        Console.WriteLine($"bigHead HashCode { bigHead.GetHashCode()}");
        while (head != null)
        {
            Console.WriteLine($"当前head value = {head.val}");

            //如果当前节点小于x，则将其放入small链表中
            if(head.val < x)
            {
                //首先 smallHead = small 
                //因为 small.next = head 指修改了 small.next 的地址 
                //所以 smallHead 也受到了影响
                //所以 smallHead.next = small.next = head
                
                //因为 small = small.next  指修改了 small 的地址
                //这时 smallHead的地址  和 small 的地址不同了
                //所以 smallHead 没收到影响 
                
                //将当前节点放入small链表尾部
                small.next = head;
                Console.WriteLine(" small.next = head 后: ");
                
                Console.WriteLine($"small HashCode { small.GetHashCode()}");
                Console.WriteLine($"smallHead HashCode { smallHead.GetHashCode()}");
                
                Console.WriteLine("small: ");
                DebugNodeTree(small);
                Console.WriteLine("\n-----");
                Console.WriteLine("smallHead: ");
                DebugNodeTree(smallHead);
                Console.WriteLine("\n-----");
                
                //前移small指针
                small = small.next;
                Console.WriteLine(" small = small.next; small前移后: ");
                
                Console.WriteLine($"small HashCode { small.GetHashCode()}");
                Console.WriteLine($"smallHead HashCode { smallHead.GetHashCode()}");
                
                Console.WriteLine("small: ");
                DebugNodeTree(small);
                Console.WriteLine("\n-----");
                Console.WriteLine("smallHead: ");
                DebugNodeTree(smallHead);
                Console.WriteLine("\n-----");
                
            }
            else
            {
                //将当前节点放入big链表尾部
                big.next = head;
                Console.WriteLine(" big.next = head 后: ");
                
                Console.WriteLine($"big HashCode { big.GetHashCode()}");
                Console.WriteLine($"bigHead HashCode { bigHead.GetHashCode()}");
                
                Console.WriteLine(" big: ");
                DebugNodeTree(big);
                Console.WriteLine("\n-----");
                Console.WriteLine("bigHead: ");
                DebugNodeTree(bigHead);
                Console.WriteLine("\n-----");
                //前移big指针
                big = big.next;
                Console.WriteLine("big = big.next; big 前移后: ");
                
                Console.WriteLine($"big HashCode { big.GetHashCode()}");
                Console.WriteLine($"bigHead HashCode { bigHead.GetHashCode()}");
                
                Console.WriteLine("big:");
                DebugNodeTree(big);
                Console.WriteLine("\n-----");
                Console.WriteLine("bigHead: ");
                DebugNodeTree(bigHead);
                Console.WriteLine("\n-----");
            }
            head = head.next;
        }
        big.next = null;
        small.next = bigHead.next;
        return smallHead.next;
    }


    private void DebugNodeTree(ListNode head)
    {
        while (head != null )
        {
            Console.Write($"{head.val} ");
            head = head.next;
        }
    }
}