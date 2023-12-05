using System.Net.Http.Headers;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using Storybook;

string choice1 = "";
string choice2 = "";
string choice3 = "";
string choice4 = "";
string choice5 = "";
string customChoice = "";
string yesno;
string firstChoice;

bool playPreselect = false;
bool playCustom = false;


Console.WriteLine("Welcome to TaleBuilder!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("1.) Create tale from preselected words.");
Console.WriteLine("2.) Create your own tale from scratch");
firstChoice = Console.ReadLine().ToUpper();

while (firstChoice != "1" && firstChoice != "2")
{
    Console.WriteLine("Please input either a 1 or a 2.");
    firstChoice = Console.ReadLine().ToUpper();
}

if (firstChoice == "1")
{
    playPreselect = true;
}

if (firstChoice == "2")
{
    playCustom = true;
}

while (playCustom)
{
    Storybook.Prompt.InventOwn(ref customChoice);

    Console.WriteLine("Again?");
   
    yesno = Console.ReadLine().ToUpper();
    while (yesno != "YES" && yesno != "NO")
    {
        Console.WriteLine("Please type yes or no only.");
        yesno = Console.ReadLine().ToUpper();
    }

    while (yesno == "YES")
    {
      Storybook.Prompt.InventNoText(ref customChoice);
      Console.WriteLine("Again?");
      yesno = Console.ReadLine().ToUpper();
    }

    if (yesno == "NO")
    {
        playCustom = false;
    }

}


while (playPreselect)
{
    Console.WriteLine("Please Enter a number: ");
    Console.WriteLine("1.) My dog ");
    Console.WriteLine("2.) My teacher ");
    Console.WriteLine("3.) My Dad ");
    Console.WriteLine("4.) My mom ");
    Console.WriteLine("5.) Santa Claus ");
    Console.WriteLine("6.) My pet hamster ");
    Console.WriteLine("7.) My friend ");
    Storybook.Prompt.PromptOne(ref choice1);
    Console.WriteLine("\n");

    Console.WriteLine("Please Enter a number: ");
    Console.WriteLine("1.) ate ");
    Console.WriteLine("2.) kissed ");
    Console.WriteLine("3.) talked to ");
    Console.WriteLine("4.) played video games with ");
    Console.WriteLine("5.) danced with ");
    Console.WriteLine("6.) sat on ");
    Console.WriteLine("7.) sneezed on");
    Storybook.Prompt.PromptTwo(ref choice2);
    Console.WriteLine("\n");

    using (SpeechSynthesizer sn = new SpeechSynthesizer())
    {
        Console.WriteLine($"{choice1}{choice2}");
        sn.Speak(choice1 + choice2);
    }

    Console.WriteLine("Please Enter a number: ");
    Console.WriteLine("1.) a smelly ");
    Console.WriteLine("2.) a noisy ");
    Console.WriteLine("3.) a crazy ");
    Console.WriteLine("4.) a smart ");
    Console.WriteLine("5.) an old ");
    Console.WriteLine("6.) a funny ");
    Console.WriteLine("7.) a scary ");
    Storybook.Prompt.PromptThree(ref choice3);
    Console.WriteLine("\n");

    using (SpeechSynthesizer sn = new SpeechSynthesizer())
    {
        Console.WriteLine($"{choice1}{choice2}{choice3}");
        sn.Speak(choice1 + choice2 + choice3);
    }

    Console.WriteLine("Please Enter a number: ");
    Console.WriteLine("1.) buffalo ");
    Console.WriteLine("2.) hot dog ");
    Console.WriteLine("3.) zombie ");
    Console.WriteLine("4.) frog ");
    Console.WriteLine("5.) meatball ");
    Console.WriteLine("6.) cow ");
    Console.WriteLine("7.) vampire ");
    Storybook.Prompt.PromptFour(ref choice4);
    Console.WriteLine("\n");

    using (SpeechSynthesizer sn = new SpeechSynthesizer())
    {
        Console.WriteLine($"{choice1}{choice2}{choice3}{choice4}");
        sn.Speak(choice1 + choice2 + choice3 + choice4);
        Console.WriteLine("\n");
    }

    Console.WriteLine("Please Enter a number: ");
    Console.WriteLine("1.) on the moon ");
    Console.WriteLine("2.) at my grandma's house ");
    Console.WriteLine("3.) in my spaghetti ");
    Console.WriteLine("4.) in a castle ");
    Console.WriteLine("5.) under the sea ");
    Console.WriteLine("6.) on a skateboard ");
    Console.WriteLine("7.) on TikTok ");
    Storybook.Prompt.PromptFive(ref choice5);
    Console.WriteLine("\n");

    using (SpeechSynthesizer sn = new SpeechSynthesizer())
    {
        Console.WriteLine($"{choice1}{choice2}{choice3}{choice4}{choice5}");
        sn.Speak(choice1 + choice2 + choice3 + choice4 + choice5);
    }

    Console.WriteLine("Would you like to create a new story?(yes/no)");
    yesno = Console.ReadLine().ToUpper();
    while (yesno != "YES" && yesno != "NO")
    {
        Console.WriteLine("Please type yes or no only.");
        yesno = Console.ReadLine().ToUpper();
    }
    if (yesno == "YES")
    {
        playPreselect = true;
    }

    if (yesno == "NO")
    {
        playPreselect = false;
    }
}
Console.WriteLine("Thank you! Have a good day!");














