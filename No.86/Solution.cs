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
        Console.WriteLine("--------------------");

        while (head != null)
        {
            Console.WriteLine($"当前head value = {head.val}");
            Console.WriteLine("--------------------");

            //如果当前节点小于x，则将其放入small链表中
            if(head.val < x)
            {
                //首先 smallHead = small 
                //因为 small.next = head 指修改了 small.next 的地址 
                //所以 smallHead 也受到了影响
                //所以 smallHead.next = small.next = head
                
                //因为 small = small.next  指修改了 small 指向了 small.next 的地址
                //这时 smallHead 依旧指向了 之前的 small 的地址
                //所以 smallHead 没收到影响 
                //所以 smallHead.next = 之前的 small.next = head
                //所以再循环中再进行 small.next = head 操作时， 会影响 smallHead.next.next
                //然后循环往复
                
                
                //将当前节点放入small链表尾部
                small.next = head;
                Console.WriteLine($"small.next = head; 操作后 ");
                Console.WriteLine($"smallHead HashCode { smallHead.GetHashCode()}");
                Console.WriteLine($"small HashCode { small.GetHashCode()}");
                Console.WriteLine($"smallHead.next HashCode { smallHead.next.GetHashCode()}");
                Console.WriteLine($"small.next HashCode { small.next.GetHashCode()}");
                small = small.next;
                Console.WriteLine($"small = small.next; 操作后 small 指向了small.next的地址");
                //这时候 smallHead.next 的地址 和 small 的地址是相同的
                //再进行 small.next = head 操作时 smallHead.next.next 也会受到影响
                //再进行 small = small.next 后  small 和 smallHead.next.next 的地址相同
                //所以 再进行 small.next = head 操作时 smallHead.next.next.next 也会受到影响
                //循环往复
                Console.WriteLine($"small HashCode { small.GetHashCode()}");
                //Console.WriteLine("small 的 地址 和 smallHead.next 的地址 应该时相同的");
                //Console.WriteLine($"smallHead.next HashCode { smallHead.next.GetHashCode()}");
            }
            else
            {
                //将当前节点放入big链表尾部
                big.next = head;
  
                
                //前移big指针
                big = big.next;
    
                
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