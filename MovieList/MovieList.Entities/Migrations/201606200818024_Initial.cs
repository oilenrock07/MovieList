namespace MovieList.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.MovieKeywords",
                c => new
                    {
                        MovieKeywordId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        Keyword = c.String(),
                    })
                .PrimaryKey(t => t.MovieKeywordId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        ImdbId = c.String(),
                        Trailer = c.String(),
                        Photos = c.String(),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Rate = c.Double(nullable: false),
                        Runtime = c.String(),
                        Rating = c.String(),
                        Summary = c.String(),
                        StoryLine = c.String(),
                        MetaScore = c.Int(nullable: false),
                        ReviewLink = c.String(),
                        AwardsLink = c.String(),
                        Country = c.String(),
                        Language = c.String(),
                        ReleasedDate = c.String(),
                        Budget = c.String(),
                        Gross = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        ImdbPersonId = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.RelatedMovies",
                c => new
                    {
                        RelatedMovieId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        ImdbId = c.String(),
                    })
                .PrimaryKey(t => t.RelatedMovieId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RelatedMovies", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieKeywords", "MovieId", "dbo.Movies");
            DropIndex("dbo.RelatedMovies", new[] { "MovieId" });
            DropIndex("dbo.MovieKeywords", new[] { "MovieId" });
            DropTable("dbo.RelatedMovies");
            DropTable("dbo.People");
            DropTable("dbo.Movies");
            DropTable("dbo.MovieKeywords");
            DropTable("dbo.Genres");
        }
    }
}
