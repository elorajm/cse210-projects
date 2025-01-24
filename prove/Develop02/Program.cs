using System;
using classes;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        journal1.AddKeyValuePair();
        classes.File file1 = new classes.File();
        while (true) {
            journal1.ShowMenu();
            string answerStr = Console.ReadLine();
            int answer = Int32.Parse(answerStr);
            if (answer == 5){
                break;
            }
            if (answer == 1){
                
                journal1.Write();
            }
            if(answer == 2){
                journal1.DisplayEntry();
            }
            if (answer == 3){
                string textentry = string.Join("|", journal1.responses);
                file1.WriteFile(textentry);
            }
            if (answer == 4){
                file1.LoadFile();
            }
        }
       
    
    }

        
}