using System.ComponentModel.Design;
using System.Speech.Synthesis;

namespace Storybook
{
    public class Prompt
    {
        public static string PromptOne(ref string choice)
        {
            int prompt1;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out prompt1))
                {

                    if (prompt1 >= 1 && prompt1 <= 7)
                    {
                        using (SpeechSynthesizer synth = new SpeechSynthesizer())
                        {
                            switch (prompt1)
                            {
                                case 1:
                                    Console.WriteLine("My dog ");
                                    synth.Speak("My dog ");
                                    choice = "My dog ";
                                    break;
                                case 2:
                                    Console.WriteLine("My teacher ");
                                    synth.Speak("My teacher ");
                                    choice = "My teacher ";
                                    break;
                                case 3:
                                    Console.WriteLine("My dad ");
                                    synth.Speak("My dad ");
                                    choice = "My dad ";
                                    break;
                                case 4:
                                    Console.WriteLine("My mom ");
                                    synth.Speak("My mom ");
                                    choice = "My mom ";
                                    break;
                                case 5:
                                    Console.WriteLine("Santa Claus ");
                                    synth.Speak("Santa Claus ");
                                    choice = "Santa Claus ";
                                    break;
                                case 6:
                                    Console.WriteLine("My pet hamster ");
                                    synth.Speak("My pet hamster ");
                                    choice = "My pet hamster ";
                                    break;
                                case 7:
                                    Console.WriteLine("My friend ");
                                    synth.Speak("My friend ");
                                    choice = "My friend ";
                                    break;

                                default:
                                    Console.WriteLine("Please only enter a number 1 to 7.");
                                    break;
                            }

                        }
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                }
            }
        }

        public static string PromptTwo(ref string choice2)
        {
            int prompt2;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out prompt2))
                {

                    if (prompt2 >= 1 && prompt2 <= 7)
                    {
                        using (SpeechSynthesizer synth2 = new SpeechSynthesizer())
                        {

                            switch (prompt2)
                            {
                                case 1:
                                    Console.WriteLine("ate ");
                                    synth2.Speak("ate ");
                                    choice2 = "ate ";
                                    break;
                                case 2:
                                    Console.WriteLine("kissed ");
                                    synth2.Speak("kissed ");
                                    choice2 = "kissed ";
                                    break;
                                case 3:
                                    Console.WriteLine("talked to ");
                                    synth2.Speak("talked to ");
                                    choice2 = "talked to ";
                                    break;
                                case 4:
                                    Console.WriteLine("played video games with ");
                                    synth2.Speak("played video games with ");
                                    choice2 = "played video games with ";
                                    break;
                                case 5:
                                    Console.WriteLine("danced with ");
                                    synth2.Speak("danced with ");
                                    choice2 = "danced with ";
                                    break;
                                case 6:
                                    Console.WriteLine("sat on ");
                                    synth2.Speak("sat on ");
                                    choice2 = "sat on ";
                                    break;
                                case 7:
                                    Console.WriteLine("sneezed on ");
                                    synth2.Speak("sneezed on ");
                                    choice2 = "sneezed on ";
                                    break;

                                default:
                                    Console.WriteLine("Please only enter a number 1 to 7.");
                                    break;
                            }

                        }
                        return choice2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                }
            }
        }

        public static string PromptThree(ref string choice3)
        {
            int prompt3;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out prompt3))
                {

                    if (prompt3 >= 1 && prompt3 <= 7)
                    {
                        using (SpeechSynthesizer synth3 = new SpeechSynthesizer())
                        {

                            switch (prompt3)
                            {
                                case 1:
                                    Console.WriteLine("a smelly ");
                                    synth3.Speak("a smelly ");
                                    choice3 = "a smelly ";
                                    break;
                                case 2:
                                    Console.WriteLine("a noisy ");
                                    synth3.Speak("a noisy ");
                                    choice3 = "a noisy ";
                                    break;
                                case 3:
                                    Console.WriteLine("a crazy ");
                                    synth3.Speak("a crazy ");
                                    choice3 = "a crazy ";
                                    break;
                                case 4:
                                    Console.WriteLine("a smart");
                                    synth3.Speak("a smart ");
                                    choice3 = "a smart";
                                    break;
                                case 5:
                                    Console.WriteLine("an old ");
                                    synth3.Speak("an old ");
                                    choice3 = "an old ";
                                    break;
                                case 6:
                                    Console.WriteLine("a funny ");
                                    synth3.Speak("a funny ");
                                    choice3 = "a funny ";
                                    break;
                                case 7:
                                    Console.WriteLine("a scary ");
                                    synth3.Speak("a scary ");
                                    choice3 = "a scary ";
                                    break;

                                default:
                                    Console.WriteLine("Please only enter a number 1 to 7.");
                                    break;
                            }

                        }
                        return choice3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                }
            }
        }

        public static string PromptFour(ref string choice4)
        {
            int prompt4;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out prompt4))
                {

                    if (prompt4 >= 1 && prompt4 <= 7)
                    {
                        using (SpeechSynthesizer synth4 = new SpeechSynthesizer())
                        {

                            switch (prompt4)
                            {
                                case 1:
                                    Console.WriteLine("buffalo ");
                                    synth4.Speak("buffalo ");
                                    choice4 = "buffalo ";
                                    break;
                                case 2:
                                    Console.WriteLine("hot dog ");
                                    synth4.Speak("hot dog ");
                                    choice4 = "hot dog ";
                                    break;
                                case 3:
                                    Console.WriteLine("zombie ");
                                    synth4.Speak("zombie ");
                                    choice4 = "zombie ";
                                    break;
                                case 4:
                                    Console.WriteLine("frog ");
                                    synth4.Speak("frog ");
                                    choice4 = "frog ";
                                    break;
                                case 5:
                                    Console.WriteLine("meatball ");
                                    synth4.Speak("meatball ");
                                    choice4 = "meatball ";
                                    break;
                                case 6:
                                    Console.WriteLine("cow ");
                                    synth4.Speak("cow ");
                                    choice4 = "cow ";
                                    break;
                                case 7:
                                    Console.WriteLine("vampire ");
                                    synth4.Speak("vampire ");
                                    choice4 = "vampire ";
                                    break;

                                default:
                                    Console.WriteLine("Please only enter a number 1 to 7.");
                                    break;
                            }

                        }
                        return choice4;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                }
            }
        }

        public static string PromptFive(ref string choice5)
        {
            int prompt5;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out prompt5))
                {

                    if (prompt5 >= 1 && prompt5 <= 7)
                    {
                        using (SpeechSynthesizer synth5 = new SpeechSynthesizer())
                        {

                            switch (prompt5)
                            {
                                case 1:
                                    Console.WriteLine("on the moon ");
                                    synth5.Speak("on the moon ");
                                    choice5 = "on the moon.";
                                    break;
                                case 2:
                                    Console.WriteLine("at my grandma's house ");
                                    synth5.Speak("at my grandma's house ");
                                    choice5 = "at my grandma's house.";
                                    break;
                                case 3:
                                    Console.WriteLine("in my spaghetti ");
                                    synth5.Speak("in my spaghetti ");
                                    choice5 = "in my spaghetti.";
                                    break;
                                case 4:
                                    Console.WriteLine("in a castle ");
                                    synth5.Speak("in a castle ");
                                    choice5 = "in a castle.";
                                    break;
                                case 5:
                                    Console.WriteLine("under the sea ");
                                    synth5.Speak("under the sea ");
                                    choice5 = "under the sea.";
                                    break;
                                case 6:
                                    Console.WriteLine("on a skateboard ");
                                    synth5.Speak("on a skateboard ");
                                    choice5 = "on a skateboard.";
                                    break;
                                case 7:
                                    Console.WriteLine("on TikTok ");
                                    synth5.Speak("on tick tock");
                                    choice5 = "on TikTok.";
                                    break;

                                default:
                                    Console.WriteLine("Please only enter a number 1 to 7.");
                                    break;
                            }

                        }
                        return choice5;
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please only input a number between 1 and 7.");
                }
            }
        }

        public static string InventOwn(ref string bns)
        {
            Console.WriteLine("\nHere you can write your own custom tale, and our silly robot friend Jasper will repeat it!");
            Console.WriteLine("Enter your text here: ");
            bns = Console.ReadLine();

            using (SpeechSynthesizer s = new SpeechSynthesizer())
            {
                s.Speak(bns);
            }
            return bns;
        }

        public static string InventNoText(ref string bns)
        {
            Console.WriteLine("Enter your text here:");
            bns = Console.ReadLine();

            using (SpeechSynthesizer s = new SpeechSynthesizer())
            {
                s.Speak(bns);
            }
            return bns;
        }
    }
}
