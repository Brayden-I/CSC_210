// BRAYDEN IMADA
using Tickets;

namespace Call_Center;

class Program
{
    static TicketQueue queue = new TicketQueue();

    static void Main(string[] args)
    {
        Console.WriteLine("=== IT Help Desk ===");

        bool running = true;
        while (running)
        {
            showMenu();
            string? input = Console.ReadLine()?.Trim();

            switch (input)
            {
                case "1": CreateTicket();        break;
                case "2": CloseTicket();         break;
                case "3": queue.displayTickets(); break;
                case "4": running = false;        break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void showMenu()
    {
        Console.WriteLine("\n1. Create Ticket");
        Console.WriteLine("2. Close Ticket");
        Console.WriteLine("3. Display All Open Tickets");
        Console.WriteLine("4. Exit");
        Console.Write("Select: ");
    }

    static void CreateTicket()
    {
        Console.Write("Customer name: ");
        string? name = Console.ReadLine()?.Trim();

        Console.Write("Problem description: ");
        string? problem = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(problem))
        {
            Console.WriteLine("Name and description cannot be empty.");
            return;
        }

        queue.enqueueTicket(new Ticket(name, problem));
        Console.WriteLine("Ticket created.");
    }

    static void CloseTicket()
    {
        Ticket? closed = queue.dequeueTicket();

        if (closed != null)
            Console.WriteLine($"Closed: {closed}");
        else
            Console.WriteLine("No open tickets to close.");
    }
}