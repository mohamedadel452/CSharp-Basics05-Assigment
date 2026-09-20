


namespace Session5Assignment

{

    // Genre Enum 
    #region Q4:Enum
    enum Genre
    {
        Fiction,     // By default, this is 0
        NonFiction,  // This is 1
        Science      // This is 2
    }
    #endregion



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

            #region Q3: Public Modifier
            Console.WriteLine("=== Q3: Public Modifier ===");
            // Set it and print it from Main.
            myBook.Title = "Clean Architecture";
            Console.WriteLine($"Book Title: {myBook.Title}");
            Console.WriteLine();
            #endregion

            #region Q4: Enum Property Assignment
            Console.WriteLine("=== Q4: Enum Property ===");
            // assign it Genre.Science, and print it.
            myBook.BookGenre = Genre.Science;
            Console.WriteLine($"Book Genre: {myBook.BookGenre}");
            Console.WriteLine();
            #endregion

            #region Q5: Enum to Int (Casting)
            Console.WriteLine("=== Q5: Enum underlying int values ===");
            // print the underlying int value by casting each to int.

            int fictionVal = (int)Genre.Fiction;
            int nonFictionVal = (int)Genre.NonFiction;
            int scienceVal = (int)Genre.Science;


            Console.WriteLine($"Genre.Fiction underlying value: {fictionVal}");
            Console.WriteLine($"Genre.NonFiction underlying value: {nonFictionVal}");
            Console.WriteLine($"Genre.Science underlying value: {scienceVal}");
            Console.WriteLine();
            #endregion

            #region Q6: Int to Enum (Casting)
            Console.WriteLine("=== Q6: Int to Enum ===");
            // Given int genreNumber = 1;, cast it into a Genre value and print the result.
            int genreNumber = 1;
            Genre castedGenre = (Genre)genreNumber;
            // Since 1 maps to NonFiction, it should print NonFiction.
            Console.WriteLine($"Integer {genreNumber} casted to Enum is: {castedGenre}");
            Console.WriteLine();
            #endregion







        }
    }
}