


namespace Session5Assignment

{
    class Program
    {
        static void Main(string[] args)
        {


            #region Q1: Private Modifier
            Console.WriteLine("=== Q1: Private Modifier ===");
            // Try to print it from Main (outside the class). What happens, and why?
          
            // Uncommenting the next line will cause a Compile-Time Error: 
           
            // 'Book.password' is inaccessible due to its protection level.
           
            
            Book myBook = new Book();
            
            
            //Console.WriteLine(myBook.password); 
        
            // WHY? Because 'private' hides the data from the outside world (Encapsulation).
            // It protects internal state from being corrupted by external classes.
            Console.WriteLine("Cannot access myBook.password because it is private. (See comments in code)");
            Console.WriteLine();
            #endregion


            #region Q2: Internal Modifier
            Console.WriteLine("=== Q2: Internal Modifier ===");
            // Print it from Main. Does it compile? Why?
            Console.WriteLine($"Copies in stock: {myBook.copiesInStock}");
            // WHY DOES IT COMPILE? Because 'internal' restricts access to the same Assembly.
      
            Console.WriteLine();
            #endregion







        }
    }
}