// See https://aka.ms/new-console-template for more information
using System.IO.Pipes;


Profile profile = new Profile();
string selectedAction = mainMenu();
navigate(selectedAction, "main");

void navigate(string selectedAction, string screen) // Allows the user to navigate around the menus.
{
    if(screen == "main" && selectedAction == "1")
    {
        editProfile();
    }
    else if(screen == "edit")
    {
        changingInformation();
    }
    else if(screen == "main" && selectedAction == "2")
    {
        viewProfile();
    }
    else if(screen == "view")
    {
        viewingInformation();
    }
}

void viewingInformation()
{
    if(selectedAction == "1" && (profile.firstName != null && profile.lastName != null))
    {
        Console.WriteLine("You have entered your name as: ");
        Console.WriteLine(profile.firstName + " " + profile.lastName);
    }
    else if(selectedAction == "2" && profile.Home.State != null)
    {
        Console.WriteLine("You live in " + profile.Home.City + " " + profile.Home.State + " at " + profile.Home.streetName + " in a " + profile.Home.Color + " house.");
        Console.WriteLine("Your zipcode is: " + profile.Home.zipCode);
    }
    else if(selectedAction == "3" && (profile.Work.Address != null))
    {
        Console.WriteLine("You work as a(n) " + profile.Work.jobTitle + " for " + profile.Work.nameOfCompany + " at " + profile.Work.Address);
    }
    else
    {
        Console.WriteLine("You have not filled out this field yet! Press enter to go back to the menu and fill out the information!");
        Console.ReadLine();
        mainMenu();
    }
    mainMenu();
}

void viewProfile()
{
    Console.WriteLine("What information would you like to view?");
    Console.WriteLine("Name (1) | Home(2) | Work(3)");
    selectedAction = Console.ReadLine();
    navigate(selectedAction, "view");
}

void changingInformation()
{
    if (selectedAction == "1")
    {
        Console.WriteLine("You would like to change your last name.");
        Console.WriteLine("Please enter your last name: ");
        profile.lastName = Console.ReadLine();
        mainMenu();
    }
    else if (selectedAction == "2")
    {
        Console.WriteLine("You would like to change your first name.");
        Console.WriteLine("Please enter your first name: ");
        profile.firstName = Console.ReadLine();
        mainMenu();
    }
    else if (selectedAction == "3")
    {
        changeHome();
        mainMenu();
    }
    else
    {
        changeWork();
        mainMenu();
    }
}

void editProfile() // lets the user choose what to edit on the edit menu.
{
    Console.WriteLine("What would you like to change?");
    Console.WriteLine("Last Name(1) | First Name(2) | Home(3) | Work(4)");
    selectedAction = Console.ReadLine();
    navigate(selectedAction, "edit");

}

string mainMenu() // Lets the user choose whether to view or change information
{
    string selectedAction = " ";
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("Edit Profile(1) | View Profile(2)");
    selectedAction = Console.ReadLine();
    return selectedAction;
}

void changeHome() // updates the user's information in the Home object.
{
    string temp = "";
    Console.WriteLine("You want to change your home information.");
    Console.WriteLine("Please enter your state: ");
    profile.Home.State = Console.ReadLine();
    Console.WriteLine("Please enter your city: ");
    profile.Home.City = Console.ReadLine();
    Console.WriteLine("Please enter your zipcode: ");
    temp = Console.ReadLine();
    profile.Home.zipCode = int.Parse(temp);
    Console.WriteLine("Please enter your home address: ");
    profile.Home.streetName = Console.ReadLine();
    Console.WriteLine("Please enter the color of your home: ");
    profile.Home.Color = Console.ReadLine();
    Console.WriteLine(" ");
}

void changeWork() // updates user's information in the Work object
{
    Console.WriteLine("You would like to change your work information.");
    Console.WriteLine("Please enter the address of your work: ");
    profile.Work.Address = Console.ReadLine();
    Console.WriteLine("Please enter the address of your work: ");
    profile.Work.Address = Console.ReadLine();
    Console.WriteLine("Please enter your job title: ");
    profile.Work.Address = Console.ReadLine();
    Console.WriteLine("Please enter the name of your company: ");
    profile.Work.nameOfCompany = Console.ReadLine();
    Console.WriteLine(" ");
}

public class Profile //Class to store user information
{
    public int? Id { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public Home? Home { get; set; }
    public Work? Work { get; set; }

    public Profile()
    {        
        this.Home = new Home();
        this.Work = new Work();
    }



}

public class Work //Class to store work characteristics
{
    public string? Address { get; set; }
    public string? jobTitle {get; set;}
    public string? nameOfCompany { get; set; }
    public Work()
    {

    }
}

public class Home //Class to store home characteristics
{
    public string? Color { get; set; }
    public string? streetName { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public int? zipCode { get; set; }

    public Home()
    {
        
    }


}


//int medianAge;
//int[] allAges = new int[5];

//for(int i=0; i<allAges.Length; i++)
//{
//    Person person = new Person();
//    person.getInfo();
//    allAges[i] = person.Age;
//}

//for(int i = 0; i < allAges.Length; i++)
//{
//    for(int j = i+1; j < allAges.Length; j++)
//    {
//        int temp = allAges[i];
//        allAges[i] = allAges[j];
//        allAges[j] = temp;
//    }
//}

//Console.WriteLine("The median age is " + allAges[2]);

//public class Person 
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person( ) 
//    { 

//    }
//    public string getInfo()
//    {
//        Console.WriteLine("Please enter a name: ");
//        Name = Console.ReadLine();
//        Console.WriteLine("Hello, " + Name + ". Enter your age: ");
//        String temp = Console.ReadLine();
//        Age = int.Parse(temp);
//        return "lala";
//    }
//}