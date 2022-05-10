using System;

class Personal
{
    public class Per
    {
        public string Name { get; set; }
        public int Sallary { get; set; }
            public Per(string name, int sallary)
        {
            Name = name; 
            Sallary = sallary;
        }

        public void GetPer()
        {
            Console.WriteLine("Name: {0}, Sallary: {1}", Name, Sallary);
                }
    }
    static void Main(string[] args)
    {
        
        Per per = new Per(Console.ReadLine(GetPer));
        per.GetPer();
        Console.WriteLine(Name); 
        Console.WriteLine(Sallary);

    }
}