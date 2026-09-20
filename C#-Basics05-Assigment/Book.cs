
// i use this namespace here to can use the Genre Enum 
namespace Session5Assignment
    { 
    class Book
    {

    #region Q1
    // Q1: Add a private string password = "secret"; field to a Book class.
    // Access Modifier 'private' means this field is ONLY accessible from INSIDE this exact class (Book).
    // If we try to access it from Program class (or anywhere else), the compiler will throw an error.
    private string password = "secret";

    #endregion

    #region Q2
    // Q2: Add an internal int copiesInStock = 5; field to Book.
    // Access Modifier 'internal' means this field is accessible from ANYWHERE within the SAME Assembly (.dll or .exe).
    // Since Book class and Program class are in the same project (same Assembly), this will compile successfully.
    internal int copiesInStock = 5;
    #endregion

    #region Q3
    // Q3: Add a public string Title; field to Book.
    // Access Modifier 'public' means it is accessible from absolutely ANYWHERE, even from other projects referencing this one.
    public string Title;
        #endregion

    #region Q4 
        // Q4: Add a Genre property to Book
        public Genre BookGenre;
    #endregion


}

}

