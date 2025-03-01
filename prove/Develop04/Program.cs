using System;

class Program
{
    static void Main(string[] args)
    {   
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome! We're so glad you're here to embark on this mindful journey.");
            Console.WriteLine("Take a moment to explore the following activities and choose the one that resonates with you the most.");
            Console.WriteLine();
            Console.WriteLine("1. Reflection Activity: A moment to connect with your thoughts and insights.");
            Console.WriteLine("2. Listing Activity: A wonderful opportunity to focus on the positives and celebrate what matters most.");
            Console.WriteLine("3. Breathing Activity: A chance to center yourself and embrace the calming power of your breath.");
            Console.WriteLine("4. Pause: Take a break whenever you need to and honor your journey at your own pace.");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 1){
                ReflectionActivity ReflectionActivity = new ReflectionActivity(10,"This activity will guide you in reflecting on the positive aspects of your life by encouraging you to list as many things as you can in a specific area.", "Reflection", 3,3, "Great job! You've completed the Reflection Activity. Well done on taking this time for yourself!");
                ReflectionActivity.StartReflectionActivity();
                
            }
            else if (selection == 2){
                ListingActivity ListingActivity = new ListingActivity(10, "This activity will encourage you to focus on the positive aspects of your life by helping you list as many things as you can in a particular area.", "Listing", 3,3, "Awesome work! You've successfully completed the Listing Activity. Keep up the great effort!");
                ListingActivity.StartListingActivity();
            }
            else if (selection == 3){
                BreathingActivity breathingActivity = new BreathingActivity(10,"This activity will guide you to relax by taking slow, mindful breaths in and out. Clear your mind and focus on the calming rhythm of your breath.", "Breathing", 3, 3, "Fantastic! You've completed the Breathing Activity. Keep breathing deeply and enjoy the peace you've created!", 5, 5);
                breathingActivity.StartBreathingActivity();
            }
            else{
                Console.Clear();
                Console.WriteLine("Goodbye for now I am excited for next time. Remember, slow and steady always leads to lasting progress.");
                Activity activity = new Activity(10, "", "", 3,3, "");
                activity.InitialPause();
                break;
            }
        }
        

        



        
        
    }
}