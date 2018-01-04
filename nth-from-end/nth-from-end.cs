using System;

public findnthFromEnd(int n)
{
    Node walker = head;
    Node sleeper = head;
    int counter = 1;

    while (walker.next != null)
    {
        if(counter >= n)
        {
            sleeper = sleeper.next;
        }
        walker = walker.next;
        counter++;
    }

    return sleeper;
}