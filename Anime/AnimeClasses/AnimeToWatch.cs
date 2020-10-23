using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AnimeClasses
{
    //https://stackoverflow.com/questions/24124185/wpf-datagrid-save-edit
    public class AnimeToWatch : INotifyPropertyChanged
    {
        public AnimeToWatch()
        {
        }
        
        private int _year = 2020;
        public int Year
        {
            set
            {
                if (value < DateTime.Now.Year && value > 1900)
                {
                    _year = value;
                }
                OnPropertyChanged(new PropertyChangedEventArgs("Year"));
            }
            get => _year;
        }

        private string _nameOfAnime = "Untitled";
        public string NameOfAnime { get => _nameOfAnime;
            set {
                _nameOfAnime = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NameOfAnime"));
            }
        }

        private int _numberOfEpisode = 12;
        public int NumberOfEpisodes
        {
            get => _numberOfEpisode;
            set
            {
                _numberOfEpisode = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NumberOfEpisodes"));
            }
        }
        private int _numbeOfMyEpisode = 1;
        public int NumberOfMyEpisode
        {
            get => _numbeOfMyEpisode;
            set
            {
                _numbeOfMyEpisode = value;
                OnPropertyChanged(new PropertyChangedEventArgs("NumberOfMyEpisode"));
            }
        }
        // from 0 to 10
        private double _myRate = 7;
        public double MyRate
        {
            get =>_myRate;
            set
            {
                if(value > 10 || value < 0)
                {
                    _myRate = 7;

                }
                else
                {
                    _myRate = value;
                }
                OnPropertyChanged(new PropertyChangedEventArgs("MyRate"));
            } 
        }
        private string _urlToWatch = "google.com";
        public string UrlToWatch
        {
            get => _urlToWatch;
            set
            {
                _urlToWatch = value;
                OnPropertyChanged(new PropertyChangedEventArgs("UrlToWatch"));
            }
        }
        private List<AnimeGenre> GenresList { get; set; } = new List<AnimeGenre>();
        public string Genres { 
            get
            {
                String res ="";
                foreach(var genre in GenresList)
                {
                    res += genre.ToString() + ", ";
                }
                if(res.Length == 0)
                {
                    return "Other";
                }
                return res.Substring(0, res.Length - 2);
            }
            set
            {
                try
                {
                    GenresList.Clear();
                    string[] genresStr = value.Replace(",", "").Split();
                    foreach (var genre in genresStr)
                    {
                        AnimeGenre g = (AnimeGenre)Enum.Parse(typeof(AnimeGenre), genre);
                        GenresList.Add(g);
                    }
                }catch(Exception e)
                {   
                    if(GenresList.Count == 0)
                    {
                        GenresList.Add(AnimeGenre.Other);
                    }
                }
                OnPropertyChanged(new PropertyChangedEventArgs("Genres"));
            }
        }
        private AnimeAgeGroup _ageGroup = AnimeAgeGroup.Shonen;
        public AnimeAgeGroup AgeGroup {
            get
            {
                return _ageGroup;
            }
            set
            {
                _ageGroup = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AgeGroup"));
            }
        }

        private string _authorOfOriginal = "No information";
        public string AuthorOfOriginal
        {
            get
            {
                return _authorOfOriginal;
            }
            set
            {
                _authorOfOriginal = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AuthorOfOriginal"));
            }
        }
        public AnimeToWatch(string nameOfAnime, int numberOfEpisodes, string urlToWatch)
        {
            NameOfAnime = nameOfAnime;
            NumberOfEpisodes = numberOfEpisodes;
            UrlToWatch = urlToWatch;
        }

        public AnimeToWatch(string nameOfAnime, int numberOfEpisodes)
        {
            NameOfAnime = nameOfAnime;
            NumberOfEpisodes = numberOfEpisodes;
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public override string ToString()
        {
            return $"{NameOfAnime}, {Year} year. {NumberOfEpisodes} episodes, watched {NumberOfMyEpisode}, " +
                $"my rate: {MyRate}, url: {UrlToWatch}, " +
                $"Genres: {Genres}, ages: {AgeGroup}, author: {AuthorOfOriginal}";
        }
    }
}