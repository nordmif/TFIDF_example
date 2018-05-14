using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFIDFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some example documents.
            string[] documents =
            {
                //"Вандалы украли бронзовые гирлянды с памятника Лесе Украинке на кладбище в Киеве.",
                //"Украина из-за похолодания начала отбирать более 100 млн кубометров газа в сутки из подземных хранилищ.",
                //"Государственная служба Украины по лекарственным средствам и контролю за наркотиками запретила партию вакцины от кори, паротита и краснухи.",
                //"Украинский боксер Артем Далакян завоевал титул чемпиона мира по версии WBA, выиграв бой у американца Брайана Вилория.",
                //"Российским олимпийцам не разрешили пройти под национальным флагом на церемонии закрытия Олимпиады-2018",
                //"Стало известно, кто представит Украину на Евровидении-2018 (ВИДЕО)",
                //"Думаете это чудо? А, нет. Это теплоэлектростанция Ахметова.",
                //"Элина продолжает радовать всю страну! С победой!!!",
                //"После того как у украинки случился инсульт польский работодатель вывез ее в соседний район и бросил на автобусной остановке",
                //"Ранее работа мобильного оператора Vodafone-Украина была прекращена на подконтрольной сепаратистам территории Луганской области из-за обрыва линии.",
                //"Эксплуатация газопровода исключена из-за угрозы жизни и здоровью населения.",
                //"Задержанием украинского хакера в Польше занимались местные правоохранители совместно с ФБР.",
                //"В субботу, 24 февраля, вступил в силу закон о реинтеграции Донбасса",
                //"Растерзанное тело нашли родители девочки.",
                //"Экс-главу предвыборного штаба Трампа подозревают в подкупе европейских политиков с целью продвижения интересов Януковича.",
                //"В ЦИК России заверили, что выборы президента в Крыму и Севастополе пройдут, несмотря на протест Украины.",
                //"Президент США заявил, что Россия наряду с Ираном и сирийскими властями несет ответственность за гуманитарный кризис в Сирии.",
                //"Киев не вернет деньги ЕС за пограничные проекты",
                //"Украина собирается построить сверхскоростную систему поездов Hyperloop. Что это такое, зачем он Украине и каковы шансы его реализации.",
                //"История, поражающая своей глупостью. Европа сворачивает проект по развитию украинских КПП. И даже требует деньги обратно.",
                //"Военнослужащие Национальной гвардии прошлись по Кривому Рогу с советскими флагами. Больше фото на сайте",
                //"Спецпроект Проголосуй в проекте «Горнолыжные курорты» за один из понравившихся и получи в подарок уикенд в горах. Финал голосования 25 февраля. Спеши получить подарок!",
                //"Круг замкнулся. Вятрович задумался над декоммунизацией Верховной Рады.",
                //"Неожиданно. Ученые Королевского колледжа Лондона заявили об опасности, которую несут в себе фруктовые чаи.",
                //"Климкин заявил, что не призывал ввести санкции против Шредера",
                //"Население Украины продолжает сокращаться",
                //"В Украине без света остаются 59 населенных пунктов",
                //"Пожар на рынке в Черновцах: пострадали три человека",
                //"У России были намерение и мотив отравить Скрипаля – Мэй",
                //"В Киеве частично ограничат движение по Северному мосту",
                //"Порошенко прибыл с визитом в Катар",
                //"Xiaomi Mi Mix 2s показали на официальных постерах",
                //"В России за ночь появилось 1,5 миллиона избирателей – СМИ",
                //"В Украине насчитали более 3000 беженцев",
                //"Швеция вызвала посла РФ из-за заявлений о причастности к яду Новичок",
                //"Канадка удивила макияжем с оптической иллюзией",
                //"Украинские стартапы за пять лет получили $400 млн",
                //"Взрыв в жилом доме Киева: стали известны подробности",
                //"На Мадагаскар обрушился шторм: 17 погибших",
                //"Госдолг США впервые превысил $21 трлн",
                //"Турция пригрозила новыми ударами в Сирии и Ираке",
                //"Названа лучшая киберспортивная игра года",
                //"Макаревич заявил, что россияне превратились в злобных дебилов",
                //"Непогода в Днепре: власти объявили два выходных дня",
                //"Россия начала масштабные военные учения",
                "This is why Facebook's data scandal matters — and what it means for your personal information",
                "Trump's Twitter feed over the past 72 hours reeks of that attempted character assassination, writes Chris Cillizza",
                "A total WITCH HUNT with massive conflicts of interest! President Donald J. Trump tweeted Monday morning",
                "One of the students who died in Parkland was buried in Dwyane Wade's jersey. Wade dedicated his season to the student, and the NBA star has now donated $200,000 to the March for Our Lives, a protest in Washington DC this Saturday. I do more than dribble, he tells CNN.",
                "Syrian President Bashar al Assad paraded the partial success of his months-long onslaught of a rebel-held suburb of Damascus by driving himself into the enclave in a Honda Civic",
                "Claire's says it has pierced more than 100 million ears around the world",
                "Spring begins Tuesday, but winter isn't ready to retire just yet",
                "Remember that huge back tattoo Ben Affleck said was fake? Apparently not so much.",
                "A drone captured stunning cherry blossoms and other signs of spring in China",
                "We're watching the opening bell as Facebook shares are down more than 4% after a data controversy that unfolded over the weekend."
            };

            // Apply TF*IDF to the documents and get the resulting vectors.
            double[][] inputs = TFIDF.Transform(documents, 0);//вывод частотных значений слов, которые встречаются хотя бы дважды
            double[][] inputs2 = TFIDF.Normalize(inputs);
            Dictionary<string, double> vocab = TFIDF._vocabularyIDF;
            // Display the output.
            for (int index = 0; index < inputs2.Length; index++)
            {
                Console.WriteLine(documents[index]);
                Console.WriteLine();
                //foreach (double value in inputs2[index])
                //{
                //    if(value != 0)
                //        Console.Write( value + ", ");
                //}

                Console.WriteLine("\n");
            }
            List<string> words = TFIDF.words;
            foreach(var word in words)
            {
                Console.WriteLine(vocab[word] + " " + word);
            }
            
            Console.WriteLine("Press any key ..");
            Console.ReadKey();
        }
    }
}
