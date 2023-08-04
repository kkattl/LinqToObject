using System.Text;
using System;

namespace LinqToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            LinqToObject linqToObject = new LinqToObject();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nОберіть що бажаєте побачити:");
                Console.WriteLine("1 - Вивести список фільмів");
                Console.WriteLine("2 - Перелік фільмів які були випущені після 2016 року");
                Console.WriteLine("3 - Згрупувати акторів за амплуа");
                Console.WriteLine("4 - Вивести список фільмів які починаюься з літери <В>");
                Console.WriteLine("5 - Згрупувати фыльми за жанром");
                Console.WriteLine("6 - Вивести список режисерів у фільмах які починаюься з літери <С>");
                Console.WriteLine("7 - Вивести список фільмів і п'єс відсортованих в алфавітному порядку");
                Console.WriteLine("8 - Вивести режисера і назву фільму який він створив");
                Console.WriteLine("9 - Вивести назви фільмів в яких знімалась Марго Роббі");
                Console.WriteLine("10 - Вивести назви фільмів і їх акторський склад");
                Console.WriteLine("11 - Вивести назви фільмів і п'єс, та їх акторський склад");
                Console.WriteLine("12 - Вивести актора і його фільмографію");
                Console.WriteLine("13 - Вивести акторів що знімаються і в фільмах і в п'єсах");
                Console.WriteLine("14 - Вивести список фільмів до яких не набрали каст");
                Console.WriteLine("15 - Вивести список фільмів де грали Марго Роббі і Вілл Сміт");
                Console.WriteLine("16 - Вивести список фільмів і п'єс до яких не набрали каст");
                Console.WriteLine("17 - Вивести список акторів і режисерів відсортованих в алфавітному порядку");
                Console.WriteLine("18 - Вивести кількість фільмів в фільмографії акторів");
                Console.WriteLine("19 - Вивести список режисерів, що зняли фільми за жанром <драма>");
                Console.WriteLine("20 - Вивести список фільмів по даті релізу починаючи з найновішого");
                Console.WriteLine("21 - Вийти\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        linqToObject.getAllFilms(d);
                        break;
                    case "2":
                        linqToObject.getFilmsOlderThanYear(d, 2016);
                        break;
                    case "3":
                        linqToObject.getGroupedActors(d);
                        break;
                    case "4":
                        linqToObject.getFilmWithV(d, "В");
                        break;
                    case "5":
                        linqToObject.getSortedGroup(d);
                        break;
                    case "6":
                        linqToObject.getFilmActorWithS(d, "C");//**/
                        break;
                    case "7":
                        linqToObject.getPlayFilm(d);
                        break;
                    case "8":
                        linqToObject.getJoinedFilmsDirectors(d);
                        break;
                    case "9":
                        linqToObject.getJoinedFilmActres(d, 3);
                        break;
                    case "10":
                        linqToObject.getJoinedFilmActors(d);
                        break;
                    case "11":
                        linqToObject.getJoinedFilmPlaysActors(d);
                        break;
                    case "12":
                        linqToObject.getJoinedActorsFilms(d);
                        break;
                    case "13":
                        linqToObject.getJoinedActorFilmPlay(d);
                        break;
                    case "14":
                        linqToObject.getFilmWithoutActors(d);
                        break;
                    case "15":
                        linqToObject.getFilmMargoAndWill(d, 2, 3);
                        break;
                    case "16":
                        linqToObject.getFilmPlayWithoutActors(d);
                        break;
                    case "17":
                        linqToObject.getConcat(d);
                        break;
                    case "18":
                        linqToObject.getCount(d);
                        break;
                    case "19":
                        linqToObject.getDirectorDrama(d, Genre.драма);
                        break;
                    case "20":
                        linqToObject.getOrderFilm(d);
                        break;
                    case "21":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір опції");
                        break;

                }
            }
        }
    }
}
