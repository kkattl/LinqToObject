using System;
using System.Collections.Generic;

namespace LinqToObject
{
    public class Data
    {
        public List<Actor> actors = new List<Actor>()
        {
            new Actor{ActorId = 1, PIB = "Леонардо Дікапріо",DateOfBirth = new DateTime(1974, 04, 11) ,TheatricalCharacter = TheatricalCharacter.різноплановий},
            new Actor{ActorId = 2,PIB = "Уілл Сміт",DateOfBirth = new DateTime(1968, 09, 25),TheatricalCharacter = TheatricalCharacter.різноплановий },
            new Actor{ActorId = 3, PIB = "Марго Робби",DateOfBirth = new DateTime(1990, 07, 02),TheatricalCharacter = TheatricalCharacter.різноплановий},
            new Actor{ActorId = 4,PIB = "Бред Питт",DateOfBirth = new DateTime(1963, 12, 18),TheatricalCharacter = TheatricalCharacter.драматичне},
            new Actor{ActorId = 5, PIB = "Джейден Мартелл",DateOfBirth = new DateTime(2003, 01, 04) ,TheatricalCharacter = TheatricalCharacter.дитяче},
            new Actor{ActorId = 6, PIB = "Фін Вулфхард",DateOfBirth = new DateTime(2002, 12, 23),TheatricalCharacter = TheatricalCharacter.дитяче},
            new Actor{ActorId = 7, PIB = "Джим Керри",DateOfBirth = new DateTime(1962, 01, 17) ,TheatricalCharacter = TheatricalCharacter.комедійне},
            new Actor{ActorId = 8,PIB = "Джонні Депп",DateOfBirth = new DateTime(1963, 06, 09),TheatricalCharacter = TheatricalCharacter.характерне},
            new Actor{ActorId = 9,PIB = "Хелена Бонем Картер",DateOfBirth = new DateTime(1966, 06, 26) ,TheatricalCharacter = TheatricalCharacter.характерне},
            new Actor{ActorId = 10,PIB = "Анджеліна Джолі",DateOfBirth = new DateTime(1975, 06, 04),TheatricalCharacter = TheatricalCharacter.драматичне},
            new Actor{ActorId = 11,PIB = "Деніал Редкліф ",DateOfBirth = new DateTime(1984, 07, 23),TheatricalCharacter = TheatricalCharacter.різноплановий},

        };


        public List<Film> films = new List<Film>()
        {
            new Film{FilmId = 1,Title = "Вавилон", Genre = Genre.драма, YearOfRelease = 2023, DirectorId = 6},
            new Film{FilmId = 2,Title = "Вовк з Уолл-стріт", Genre = Genre.драма, YearOfRelease = 2014, DirectorId = 5},
            new Film{FilmId = 3,Title = "Загін Самогубців", Genre = Genre.екшен, YearOfRelease = 2016,DirectorId = 3},
            new Film{FilmId = 4,Title = "Одного разу в голівуді", Genre = Genre.комедія, YearOfRelease = 2019, DirectorId = 4},
            new Film{FilmId = 5,Title = "Фокус", Genre = Genre.романтика, YearOfRelease = 2015, DirectorId = 2},
            new Film{FilmId = 6,Title = "Воно", Genre = Genre.жахи, YearOfRelease = 2017, DirectorId = 1},
            new Film{FilmId = 7,Title = "Дуже дивні справи", Genre = Genre.фантастика, YearOfRelease = 2016, DirectorId = 12},
            new Film{FilmId = 8,Title = "Бійцівський клуб", Genre = Genre.триллер, YearOfRelease = 1999, DirectorId = 8},
            new Film{FilmId = 9,Title = "Суінні Тод", Genre = Genre.жахи, YearOfRelease = 2007, DirectorId = 7},
            new Film{FilmId = 10,Title = "Маска", Genre = Genre.комедія, YearOfRelease = 1994, DirectorId =10},
            new Film{FilmId = 11,Title = "Турист", Genre = Genre.драма, YearOfRelease = 2010, DirectorId =11},
            new Film{FilmId = 12,Title = "Спочатку вони вбили мого батька", Genre = Genre.драма, YearOfRelease = 2017, DirectorId = 9},
            new Film{FilmId = 13,Title = "Дім дивних дітей міс Піллігрім", Genre = Genre.фантастика, YearOfRelease = 2016, DirectorId = 7}
        };
        public List<Director> directors = new List<Director>()
        {
            new Director{DirectorId = 1,PIB = "Андрес Мускьетті"},
            new Director{DirectorId = 2,PIB = "Гленн Фікарра"},
            new Director{DirectorId = 3,PIB = "Девід Ейр"},
            new Director{DirectorId = 4,PIB = "Квентін Тарантіно"},
            new Director{DirectorId = 5,PIB = "Мартін Скорсезе"},
            new Director{DirectorId = 6,PIB = "Дем'ян Шазелл"},
            new Director{DirectorId = 7,PIB = "Тім Бертон"},
            new Director{DirectorId = 8,PIB = "Девід Фінчер"},
            new Director{DirectorId = 9,PIB = "Анджеліна Джолі"},
            new Director{DirectorId = 10,PIB = "Чак Рассел"},
            new Director{DirectorId = 11,PIB = "Флоріан Хенкель фон Доннерсмарк"},
            new Director{DirectorId = 12,PIB = "брати Даффери"}
        };

        public List<Play> plays = new List<Play>()
        {
            new Play{PlayId = 1, Title = "Ромео і Джульета", Genre = Genre.романтика},
            new Play{PlayId = 2, Title = "Гамлет", Genre = Genre.драма},
            new Play{PlayId = 3, Title = "Еквус", Genre = Genre.драма},
            new Play{PlayId = 4, Title = "Кайдашева родина", Genre = Genre.комедія},
            new Play{PlayId = 5, Title = "Катерина", Genre = Genre.драма},

        };

        public List<Participation> participations = new List<Participation>()
        {
            new Participation{FilmId = 1,ActorId = 4},
            new Participation{FilmId = 1,ActorId = 3},
            new Participation{FilmId = 2,ActorId = 1},
            new Participation{FilmId = 2,ActorId = 3},
            new Participation{FilmId = 3,ActorId = 3},
            new Participation{FilmId = 3,ActorId = 2},
            new Participation{FilmId = 4,ActorId = 1},
            new Participation{FilmId = 4,ActorId = 3},
            new Participation{FilmId = 4,ActorId = 4},
            new Participation{FilmId = 5,ActorId = 2},
            new Participation{FilmId = 5,ActorId = 3},
            new Participation{FilmId = 6,ActorId = 5},
            new Participation{FilmId = 6,ActorId = 6},
            new Participation{FilmId = 7,ActorId = 5},
            new Participation{FilmId = 7,ActorId = 6},
            new Participation{FilmId = 8,ActorId = 4},
            new Participation{FilmId = 8,ActorId = 9},
            new Participation{FilmId = 9,ActorId = 8},
            new Participation{FilmId = 9,ActorId = 9},
            new Participation{FilmId = 10,ActorId = 7},
            new Participation{FilmId = 11,ActorId = 8},
            new Participation{FilmId = 11,ActorId = 10},

        };

        public List<Act> acts = new List<Act>()
        {
            new Act{PlayId = 1,ActorId = 8 },
            new Act{PlayId = 1,ActorId = 9},
            new Act{PlayId = 2,ActorId = 1},
            new Act{PlayId = 3,ActorId = 11},
        };
    }
}
