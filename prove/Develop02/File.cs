using System.IO;

namespace classes{
    public class File 
    {
        public void WriteFile(string text){

            

            Console.WriteLine("What is the journal file you'd like to choose? Enter .txt at the end");
            string _fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
    
            outputFile.WriteLine(text);
            
        
            }
        }   

        public void LoadFile(){
            Console.WriteLine("What is the filename you'd like to Load?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
                
            }
            
            
        }
    }
}