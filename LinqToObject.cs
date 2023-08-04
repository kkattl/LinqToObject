using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public class LinqToObject
    {
        //1 - Вивести список фільмів
        public void getAllFilms(Data datas)
        {
            var result = from f in datas.films select f;
            foreach (var row in result)
            {
                Console.WriteLine(row.ToString());
            }
        }
        //2 - Перелік фільмів які були випущені після 2016 року
        public void getFilmsOlderThanYear(Data data, double yr)
        {
            var result = data.films.Where(t => t.YearOfRelease > yr);
            foreach (var row in result)
            {
                Console.WriteLine(row.ToString());
            }
        }
        //3 - Згрупувати акторів за амплуа
        public void getGroupedActors(Data data)
        {

            var result = from a in data.actors
                         group a by a.TheatricalCharacter;
            foreach (var group in result)
            {
                Console.WriteLine("\nАктор: {0}", group.Key);
                foreach (var row in group)
                {
                    Console.WriteLine("     {0}", row.PIB);
                }
            }
        }
        //4 - Вивести список фільмів які починаюься з літери <В>
        public void getFilmWithV(Data data, string letter)
        {
            var result = data.films.Where(f => f.Title?.StartsWith(letter) ?? false);
            foreach (var row in result)
            {
                Console.WriteLine(row.ToString());
            }
        }
        //5 - Згрупувати фыльми за жанром
        public void getSortedGroup(Data data)
        {
            var result = data.films.GroupBy(a => a.Genre);
            foreach (var group in result)
            {
                Console.WriteLine("Жанр: {0}", group.Key);
                foreach (var row in group)
                {
                    Console.WriteLine("{0}", row.Title);
                }
                Console.WriteLine("\n");
            }
        }
        //6 - Вивести список режисерів у фільмах які починаюься з літери <С>
        public void getFilmActorWithS(Data data, string letter)
        {
            var result = data.films.Where(f => f.Title?.StartsWith(letter) ?? false);//.Join(data.directors,
            //f => f.FilmId,
            //d => d.DirectorId,
            //(f, d) => new { title = f.Title, pib = d.PIB });
            foreach (var row in result)
            {
                Console.WriteLine("Режисер: {0}({0})", /*row.pib*/ row.Title);
            }

        }
        //7 - Вивести список фільмів і п'єс відсортованих в алфавітному порядку
        public void getPlayFilm(Data data)
        {
            var result = data.films.Concat(data.plays).OrderBy(item => item.Title).ToList();
            foreach (var row in result)
            {
                Console.WriteLine(row.ToString());
            }
        }
        //8 - Вивести режисера і назву фільму який він створив
        public void getJoinedFilmsDirectors(Data data)
        {
            var result = from d in data.directors
                         join f in data.films on d.DirectorId equals f.DirectorId
                         select new
                         {
                             title = f.Title,
                             pib = d.PIB
                         };
            foreach (var row in result)
            {
                Console.WriteLine("Назва:{0} \nРежисер:{1}\n", row.title, row.pib);
            }
        }
        //9 - Вивести назви фільмів в яких знімалась Марго Роббі
        public void getJoinedFilmActres(Data data, int id)
        {
            var result = from p in data.participations
                         where p.ActorId == id
                         join f in data.films on p.FilmId equals f.FilmId
                         select new
                         {
                             title = f.Title
                         };
            foreach (var row in result)
            {
                Console.WriteLine(row.title);
            }
        }
        //10 - Вивести назви фільмів і їх акторський склад
        public void getJoinedFilmActors(Data data)
        {
            var result = from p in data.participations
                         join a in data.actors on p.ActorId equals a.ActorId
                         join f in data.films on p.FilmId equals f.FilmId
                         group new { p, a, f } by f.Title into g
                         select new
                         {
                             Title = g.Key,
                             Cast = from x in g
                                    select new
                                    {
                                        pib = x.a.PIB
                                    }
                         };
            foreach (var item in result)
            {
                Console.WriteLine("Фільм: {0}\n     каст:", item.Title);

                foreach (var row in item.Cast)
                {
                    Console.WriteLine("     {0}", row.pib);
                }
                Console.WriteLine("\n");
            }

        }
        //11 - Вивести назви фільмів і п'єс, та їх акторський склад
        public void getJoinedFilmPlaysActors(Data data)
        {
            var result1 = from p in data.participations
                          join a in data.actors on p.ActorId equals a.ActorId
                          join f in data.films on p.FilmId equals f.FilmId
                          group new { p, a, f } by f.Title into g
                          select new
                          {
                              Title = g.Key,
                              Cast = from x in g
                                     select new
                                     {
                                         pib = x.a.PIB
                                     }
                          };

            var result2 = from ac in data.acts
                          join a in data.actors on ac.ActorId equals a.ActorId
                          join p in data.plays on ac.PlayId equals p.PlayId
                          group new { ac, a, p } by p.Title into g
                          select new
                          {
                              Title = g.Key,
                              Cast = from x in g
                                     select new
                                     {
                                         pib = x.a.PIB
                                     }
                          };
            var result = result1.Concat(result2);


            foreach (var item in result)
            {
                Console.WriteLine("\nНазва: {0}\n     каст:", item.Title);

                foreach (var row in item.Cast)
                {
                    Console.WriteLine("     {0}", row.pib);
                }
            }
        }
        //12 - Вивести актора і його фільмографію
        public void getJoinedActorsFilms(Data data)
        {
            var result = from p in data.participations
                         join a in data.actors on p.ActorId equals a.ActorId
                         join f in data.films on p.FilmId equals f.FilmId
                         group new { p, a, f } by a.PIB into g
                         select new
                         {
                             PIB = g.Key,
                             Filmography = from x in g
                                           select new
                                           {
                                               title = x.f.Title
                                           }
                         };
            foreach (var item in result)
            {
                Console.WriteLine("\nАктор: {0}   \nфільмографія:", item.PIB);

                foreach (var row in item.Filmography)
                {
                    Console.WriteLine("     {0}", row.title);
                }
            }

        }
        //13 - Вивести акторів що знімаються і в фільмах і в п'єсах
        public void getJoinedActorFilmPlay(Data data)
        {
            var result = data.actors.Where(a => data.acts.Any(ac => ac.ActorId == a.ActorId)
            && data.participations.Any(p => p.ActorId == a.ActorId) && a.PIB != null).Select(a => a.PIB).Distinct();

            foreach (var row in result)
            {
                Console.WriteLine(row);
            }

        }
        //14 - Вивести список фільмів до яких не набрали каст
        public void getFilmWithoutActors(Data data)
        {
            var result = from f in data.films
                         join p in data.participations on f.FilmId equals p.FilmId into ps
                         from p in ps.DefaultIfEmpty()
                         where p == null
                         select f;

            foreach (var film in result)
            {
                Console.WriteLine(film.Title);
            }
        }
        //15 - Вивести список фільмів де грали Марго Роббі і Вілл Сміт
        public void getFilmMargoAndWill(Data data, int a2, int a3)
        {
            var result = from f in data.films
                         where data.participations.Any(p => p.FilmId == f.FilmId && p.ActorId == a2) &&
                               data.participations.Any(p => p.FilmId == f.FilmId && p.ActorId == a3)
                         select f;
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }

        }
        //16 - Вивести список фільмів і п'єс до яких не набрали каст
        public void getFilmPlayWithoutActors(Data data)
        {
            var result1 = from f in data.films
                          join p in data.participations on f.FilmId equals p.FilmId into ps
                          from p in ps.DefaultIfEmpty()
                          where p == null
                          select new
                          {
                              title = f.Title
                          };
            var result2 = from p in data.plays
                          join a in data.acts on p.PlayId equals a.PlayId into ps
                          from a in ps.DefaultIfEmpty()
                          where a == null
                          select new
                          {
                              title = p.Title
                          };
            var result = result1.Concat(result2);

            foreach (var row in result)
            {
                Console.WriteLine(row.title);
            }

        }
        //17 - Вивести список акторів і режисерів відсортованих в алфавітному порядку
        public void getConcat(Data data)
        {
            var result = data.actors.Concat<Actor>(data.directors).OrderBy(x => x.PIB);
            foreach (var row in result)
            {
                Console.WriteLine(row.PIB);
            }
        }
        //18 - Вивести кількість фільмів в фільмографії акторів
        public void getCount(Data data)
        {
            var result = data.actors.GroupJoin(data.participations, a => a.ActorId, p => p.ActorId, (a, p) => new { actor = a, participations = p })
                .Select(x => new { pib = x.actor.PIB, filmography = x.participations.Count() });
            foreach (var row in result)
            {
                Console.WriteLine("{0}:\n фільмографія налічує - {1} фільмів", row.pib, row.filmography);
            }
        }
        //19 - Вивести список режисерів, що зняли фільми за жанром <драма>
        public void getDirectorDrama(Data data, Genre genre)
        {
            var result = from f in data.films
                         join d in data.directors on f.DirectorId equals d.DirectorId
                         where f.Genre == genre
                         select d.PIB;
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
        }
        //20 - Вивести список фільмів по даті релізу починаючи з найновішого
        public void getOrderFilm(Data data)
        {
            var result = data.films.OrderByDescending(f => f.YearOfRelease);
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
        }
    }
}
