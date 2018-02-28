using System;

namespace RestaurantMenuAppC6Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Readline();
        }
    }
}



//things we will have & want the program to do: 
/*
    have a menu that displays 3 options/user picks choice: 
        Updated as of {{DATE last Updated}}
        1. Appetizer
        2. Main Course
        3. Dessert
        4. Add Menu Items
        5. Remove Menu Items
        Console.Readline();

if user picks 1
    1. Appetizer
       Display menu name / Appetizer - Console.WriteLine("Appetizer" / [1])
        Console.WriteLine(*****)
       foreach menu item in appetizer)
        if(new)
            {
                Console.Write(**new**)
            }
        ORR if(new)
            append(*NEW*) to [0] after below is done)

            Console.WriteLine({Display menu item} - {price:C} 
            Console.WriteLine{description}
        
    (   **repeat
    if user picks 2 
        2. Main Course

    if user picks 3
        3. Dessert )

if user picks 4
    Add an item to: (Cycle through menu choices)   //needs - name, price, description & category
        1. Appetizer
        2. Main Course
        3. Dessert
    user picks a menu- Console.ReadLine();
        (userinput chooses the menu and holds item for below)
    List newItem;
        Console.WriteLine(Add the {{menu}} item:)

        Console.WriteLine(Item Name:);
        newitem = Console.ReadLine();

        Console.WriteLine(Add the {{item/newItem[0]}} price:);
        newitem +=Console.ReadLine();

        Console.WriteLine(Add the {{item/newItem[0]}} Description);
        newitem +=Console.ReadLine();

        SelectedMenu.ADD(newitem);

        Console.WriteLine(newitem was added!);

if user picks 5
        Console.WriteLine(What would you like to remove from the {{menu}}?
        removeItem = Console.ReadLine()

        if MenuList.Contains(removeItem) orrrrr have user select a menu and then ask them for the item.
        
        else{Item was never on the menu, please try again or exit.}
        */