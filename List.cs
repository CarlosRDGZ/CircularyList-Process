namespace Circulary
{
    class List
    {
        private Process head = null;
        public Process Head => this.head;

        public void Add(Process p)
        {
            if (this.head != null)
            {
                Process beforeHead = this.head.Previous;

                p.Next = this.head;
                p.Previous = beforeHead;

                beforeHead.Next = p;
                this.head.Previous = p;
            }
            else
            {
                this.head = p;
                this.head.Next = p;
                this.head.Previous = p;
            }
        }

        public Process DeleteFirst()
        {
            if (this.head != null)
            {
                if (this.head.Next != this.head)
                {
                    this.head.Previous.Next = this.head.Next;
                    this.head.Next.Previous = this.head.Previous;

                    Process head = this.head;
                    this.head = this.head.Next;

                    head.Previous = head.Next = null;
                    return head;
                }
                else
                {
                    Process temp = this.head;
                    this.head = temp.Previous = temp.Next = null;
                    return temp;
                }
            }
            return null;
        }

        public Process DeleteLast()
        {
            if (this.head != null)
            {
                if (this.head.Next != this.head)
                {
                    Process beforeHead = this.head.Previous;

                    beforeHead.Previous.Next = this.head;
                    this.head.Previous = beforeHead.Previous;

                    beforeHead.Previous = beforeHead.Next = null;
                    return beforeHead;
                }
                else
                {
                    Process temp = this.head;
                    this.head = temp.Previous = temp.Next = null;
                    return temp;
                }
            }
            return null;
        }
    }
}
/*
if (this.head != null) {
      if (this.head.next != this.head) {
        this.head.previous.next = this.head.next
        this.head.next.previous = this.head.previous

        let head = this.head
        this.head = this.head.next

        head.previous = head.next = null
        return head
      } else {
        let temp = this.head
        this.head = null
        temp.previous = temp.next = null
        return temp
      }
    }
    return null
 */