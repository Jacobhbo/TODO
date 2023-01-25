namespace TODO
{
    internal class Menu
    {
        List<ToDoItem> todoList = new();

        //Constructor that runs when object is instantiated (with new keyword).
        public Menu()
        {
            while (true)
            {
                MainMenu();
            }
        }
        //Start menu
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1) Add new\n(2) Show List");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    CreateItem();
                    break;
                case '2':
                    ShowList();
                    break;
                case '3':
                    UpdateItem();
                    break;
                case '4':
                    break;
                default:
                    break;
            }
        }

        //Show TodoList shows TodoItems
        void ShowList()
        {
            foreach (ToDoItem? item in todoList)
            {
                ShowItem(item);
            }
        }

        //Create Item
        private void CreateItem()
        {
            ToDoItem newItem = new ToDoItem();
            newItem.Created = DateTime.Now;

            Console.WriteLine("What to do?");
            newItem.Todo = Console.ReadLine();

            Console.WriteLine("When to do it?");
            string dl = Console.ReadLine();
            //TODO Get different input regarding dates and times
            newItem.Deadline = DateTime.Parse(dl);
            newItem.IsDone = false;

            Console.WriteLine("Is it important?");
            newItem.IsFavorite = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;

            todoList.Add(newItem);
        }

        //Read TodoItem
        private void ShowItem(ToDoItem toDoItem)
        {
            int i = todoList.IndexOf(toDoItem);
            Console.WriteLine($"What: {toDoItem.Todo} When: {toDoItem.Deadline} isDone: {toDoItem.IsDone}");
            //Console.WriteLine("What: {0} When: {1} isDone: {2}", toDoItem.Todo, toDoItem.Deadline, toDoItem.IsDone);
            //Console.WriteLine("What: " + toDoItem.Todo + "When: " + toDoItem.Deadline + "isDone: " + toDoItem.IsDone);
        }


        //Update Item
        private void UpdateItem()
        {
            Console.WriteLine("Update. Pick item index for todoitem that needs updating");
            ShowItem();
            int i = int.Parse(Console.ReadLine());
            ToDoItem tdi = todoList[i];
            Console.WriteLine("What to do?");
            string input = Console.ReadLine();
            if (input != "") 
                tdi.Description= input;


        }


        //Delete Item
        private void DeleteItem(int itemIndex)
        {
            if (itemIndex >= 0 && itemIndex < todoList.Count)
            {
                todoList.RemoveAt(itemIndex);
                Console.WriteLine("Item was deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid index, please enter a valid index:");
            }
        }
    }
}