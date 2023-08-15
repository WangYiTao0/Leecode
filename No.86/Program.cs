
Solution solution = new Solution();
ListNode head = new ListNode(1);
ListNode node = head;
node.next = new ListNode(4);
node = node.next;
node.next = new ListNode(3);
node = node.next;
node.next = new ListNode(2);
node = node.next;
node.next = new ListNode(5);
node = node.next;
node.next = new ListNode(2);
node = node.next;
ListNode result = solution.Partition(head, 3);
Console.WriteLine($"预期结果: 1 2 2 4 3 5");
Console.WriteLine($"结果: {result.val} {result.next.val} {result.next.next.val} {result.next.next.next.val} {result.next.next.next.next.val} {result.next.next.next.next.next.val}");