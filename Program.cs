using Level_20_The_Properties_of_Arrows;

string userArrowHead;
string userArrowFletching;
float userShaftLength;
int howManyArrows;
float totalArrowOrderCost = 0f;



Dialoge.Greeting();

//initiates the veriable to contain a response for number of arrows. This will feed the Arrow Array to determine the array's length.
howManyArrows = Convert.ToInt16(Console.ReadLine());

//initializes Arrows based on the number customer going to purchase.
Arrow[] purchase = new Arrow[howManyArrows];

//Displays a welcome message introducing the shop.
Dialoge.FirstMenuIntroduction();

//initializes each of the arrows in the 'purchase' array
//also contains the work that will be done to design the arrows.
for (int i = 0; i < purchase.Length; i++)
{
    purchase[i] = new Arrow();

    Menus.MenuPrint();

    //ask which arrow head the user wants.
    Dialoge.ArrowheadOrder();
    userArrowHead = Console.ReadLine();
    while (purchase[i].ArrowHeadInputVerify(userArrowHead) == false)
    {
        Menus.MenuPrint();
        Dialoge.ArrowHeadError();
        userArrowHead = Console.ReadLine();
    }

    //asks which fletching the user wants
    Dialoge.FletchingOrder();
    userArrowFletching = Console.ReadLine();
    while (purchase[i].ArrowFletchingInputVerify(userArrowFletching) == false)
    {
        Menus.MenuPrint();
        Dialoge.ArrowHeadError();
        userArrowFletching = Console.ReadLine();
    }

    //determines arrow shaft length
    Dialoge.ShaftOrder();
    userShaftLength = Convert.ToSingle(Console.ReadLine());
    purchase[i].ShaftLength = userShaftLength;
    //adds shaft length cost to arrow cost.
    purchase[i].AddShaftToCost();

    //calls the individual arrow's order summary with cost. 
    //Also adds the cost of the arrow to the variable that is holding that information
    purchase[i].SingleArrowOrderSummary();
    totalArrowOrderCost += purchase[i].AddArrowToTotal();
    Dialoge.dashedLine();

    if (i < purchase.Length - 1)
    {
        Dialoge.AnotherArrow();
    }
    else
        break;


}

//provides a total order summary
Console.WriteLine($"Sir, I really think that you have picked yourself up {howManyArrows} great arrows! And you got them for only {totalArrowOrderCost} " +
    $"\nGold...sounds like a steal to me!!!");