using back_end.Models;

namespace back_end.Repository
{
    public class MoviesRepository
    {
        private List<Movie> list;
        public MoviesRepository()
        {
            this.list = new List<Movie>()
            {
                new Movie(){ 
                    Id = 1,
                    Name = "Harry Potter",
                    Description = "An Harry Potter Movie",
                    ImageUrl = "https://m.media-amazon.com/images/I/81Ta2C1GeBS._SY445_.jpg"
                },
                new Movie(){
                    Id = 2,
                    Name = "Interstellar",
                    Description = "An Interstellar Movie",
                    ImageUrl = "https://m.media-amazon.com/images/I/A1JVqNMI7UL._AC_SL1500_.jpg"
                },
                new Movie(){
                    Id = 3,
                    Name = "Inception",
                    Description = "An Inception Movie",
                    ImageUrl = "https://m.media-amazon.com/images/I/51bRJ3i-O8L._SY445_.jpg"
                },
                new Movie(){
                    Id = 4,
                    Name = "Wallstreet Wolf",
                    Description = "A Wallstreet Movie",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_.jpg"
                },
            };
        }

        public List<Movie> getAllMovies()
        {
            return this.list;
        }

        public Movie getMovieById(int Id)
        {
            return this.list.FirstOrDefault(x => x.Id == Id);
        }
    }
}
