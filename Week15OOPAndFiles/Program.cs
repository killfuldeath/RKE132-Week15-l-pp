string[] datas = GetDataFromMyFile();
//ReadDataFromArray(datas);



List<movie> myMovies = new List<movie>();


foreach(string line in datas)
{
    string[] tempor = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    movie newMovie = new movie(tempor[0], tempor[2]);
    myMovies.Add(newMovie);
}

foreach(movie movie in myMovies)
{
    Console.WriteLine($"One of my most hated movies is {movie.Title}, which released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\henri\Documents\data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] data)
{
    foreach(string line in data)
    {
        Console.WriteLine(line);
    }
}

class movie
{
    string title;
    string year;
    string rating;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}