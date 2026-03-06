using LLNoder;

namespace Tickets;

public class Ticket
{
    // STATIC FIELDS
    private static int nextId = 1;

    // PUBLIC FIELDS
    public int    TicketId;           // Unique ID for this ticket
    public string CustomerName;       // Name of the person who filed the ticket
    public string ProblemDescription; // Description of the issue reported

    // CONSTRUCTOR
    public Ticket(string customerName, string problemDescription)
    {
        TicketId           = nextId++;          // Assign then increment the global counter
        CustomerName       = customerName;
        ProblemDescription = problemDescription;
    }

    // METHODS
    public override string ToString()
    {
        return $"[#{TicketId}] Customer: {CustomerName} | Issue: {ProblemDescription}";
    }
}

public class TicketQueue
{
    // FIELDS
    private LLNode<Ticket>? front;
    private LLNode<Ticket>? back;
    private int count;

    // CONSTRUCTOR
    public TicketQueue()
    {
        front = null;
        back  = null;
        count = 0;
    }

    // METHODS
    public void enqueueTicket(Ticket ticket)
    {
        LLNode<Ticket> newNode = new LLNode<Ticket>(ticket);

        if (back == null) // Queue is empty, node becomes both front and back
        {
            front = newNode;
            back  = newNode;
        }
        else // Attach to the tail, then advance the back pointer
        {
            back.next = newNode;
            back      = newNode;
        }

        count++;
    }

    // Remove and return ticket from the FRONT of the queue
    public Ticket? dequeueTicket()
    {
        // Case 1: nothing to close
        if (front == null) return null;

        Ticket closed = front.data;
        front = front.next;

        // If the list becomes empty reset the back
        if (front == null) back = null;

        count--;
        return closed;
    }

    // Display all tickets in FIFO order
    public void displayTickets()
    {
        if (front == null)
        {
            Console.WriteLine("No open tickets.");
            return;
        }

        LLNode<Ticket>? current = front;
        int position = 1;

        while (current != null)
        {
            Console.WriteLine($"  {position}. {current.data}");
            current = current.next;
            position++;
        }
    }

    public bool isEmpty() => front == null;
}
