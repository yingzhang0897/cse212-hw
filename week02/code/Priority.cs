public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue

        // Test 1
        // Scenario: an item (which contains both data and priority) can be added to the back of the queue.
        // Expected Result: [food (Pri:3), clothes (Pri:3), electronics (Pri:5), cars (Pri:5)]
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("food", 3);
        priorityQueue.Enqueue("clothes",3);
        priorityQueue.Enqueue("electronics",5);
        priorityQueue.Enqueue("cars", 5);
        Console.WriteLine(priorityQueue);
        Console.WriteLine("---------");

        // Test 2
        // Scenario: an item with the highest priority can be removed with its value being returned.
        // Expected Result:  cars (Pri:6)]
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("food", 3);
        priorityQueue.Enqueue("clothes",2);
        priorityQueue.Enqueue("electronics",5);
        priorityQueue.Enqueue("cars", 6);
        priorityQueue.Dequeue();
        


        Console.WriteLine("---------");

        // Test 3
        // Scenario: the item closest to the front of the queue which shares same priority will be removed and its value returned.
        // Expected Result: electronics (Pri:5)
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("food", 3);
        priorityQueue.Enqueue("clothes",3);
        priorityQueue.Enqueue("electronics",5);
        priorityQueue.Enqueue("cars", 5);

        priorityQueue.Dequeue();


        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: 
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine("---------");
    }
}