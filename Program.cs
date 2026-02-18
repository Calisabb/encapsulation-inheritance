namespace encapsulation_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(32, "asus", 12, 2899, 1024);
            notebook.ShowFullData();
            notebook.Sale(true);  


        }
    }
}
