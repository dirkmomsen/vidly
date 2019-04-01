namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            var dateAdded = DateTime.Now;
            Sql("INSERT INTO Movies " +
                "(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Hangover', 'Comedy', '2009/11/06', '" + dateAdded.ToString("yyyy/MM/dd") + "', 5)");
            Sql("INSERT INTO Movies " +
                "(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Die Hard', 'Action', '1988/07/12', '" + dateAdded.ToString("yyyy/MM/dd") + "', 1)");
            Sql("INSERT INTO Movies " +
                "(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('The Terminator', 'Action', '1984/10/26', '" + dateAdded.ToString("yyyy/MM/dd") + "', 3)");
            Sql("INSERT INTO Movies " +
                "(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Toy Story', 'Family', '1995/11/19', '" + dateAdded.ToString("yyyy/MM/dd") + "', 2)");
            Sql("INSERT INTO Movies " +
                "(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                "VALUES ('Titanic', 'Romance', '1997/12/19', '" + dateAdded.ToString("yyyy/MM/dd") + "', 4)");

        }
        
        public override void Down()
        {
        }
    }
}
