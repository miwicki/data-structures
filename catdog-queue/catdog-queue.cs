using System;

namespace catdog
{
    class methods
    {
        int catCounter = 1;
        int dogCounter = 2;
        internal Node Next;
        internal Node catHead;
        internal Node dogHead;
        
        EnqueueCat(int val, Node newCatNode)
        {
            if (catHead = null)
            {
                newCatNode = catHead;
                newCatNode.val = catCounter;

            }
            newCatNode.Next = catCounter;
            newCatNode.val = catCounter += 2;
            catCounter = catCounter + 2;
        }

        EnqueueDog(int val, Node newDogNode)
        {
            if(dogHead = null)
            {
                newDogNode = dogHead;
                newDogNode.val = dogCounter;

            }
            newDogNode.Next = dogCounter;
            newDogNode.val = dogCounter += 2;
            dogCounter = dogCounter + 2;
        }

        AskCat()
        {
            return catHead;
        }

        AskDog()
        {
            return dogHead;
        }

        AskAny()
        {
            if (catHead.val > dogHead.val) return dogHead;
            else return catHead;
        }
    }

}

