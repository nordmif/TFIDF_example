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
                "We're watching the opening bell as Facebook shares are down more than 4% after a data controversy that unfolded over the weekend.",
                "Lolade Siyonbola, a black Yale University student, was napping in her dorm's common room when a white student called police. There needs to be punitive measures for people who act out of racially motivated bias,  Siyonbola told Good Morning America https://cnn.it/2GhfTeq",
                "We’re live at the White House for the press briefing.",
                "The Humbolt Broncos junior hockey team will be in the rink again in time for the fall season. The team lost 10 players, two coaches and a trainer in a devastating crash that killed 16 people.",
                "I just don't know what goes on in that White House mentality for there not being an apology for that terrible remark",
                "Howard Forever. In an inspiring commencement speech, Chadwick Boseman, the man behind the Black Panther mask, tells Howard University graduates that this is your time, ending with the movie's iconic salute. https://cnn.it/2IjiF8X",
                "This 33-year-old writer and activist has mobilized tens of thousands of Ganzans in recent weeks",
                "The Supreme Court struck down a 1992 federal law that prohibited most states from authorizing sports betting",
                "The US officially relocated its Embassy to Jerusalem, formally upending decades of American foreign policy in a move that was met with clashes and protests along the Israeli-Gaza border.",
                "The man behind the Black Panther mask gives a stirring graduation speech, ending with the iconic salute from the movie saying, Howard Forever",
                "“By moving our embassy to Jerusalem, we have shown the world once again that the United States can be trusted... The United States stands with Israel because we believe — we know — that it is the right thing to do,” says White House senior adviser Jared Kushner at the US Embassy opening in Jerusalem https://cnn.it/2L0Gssf",
                "We're watching the markets live as the Dow goes for its eighth straight day of gains — the longest winning streak for the index since November 2017 https://cnnmon.ie/2GcUovB",
                "“Be fearless… Don’t just accept the world you inherit today. Don’t just accept the status quo. No big challenge has ever been solved… unless people dare to try something different”: Apple CEO Tim Cook shared this message of inspiration to Duke University graduates https://cnn.it/2L0Uzxp",
                "We're live in Jerusalem, where the Trump administration is officially moving the US embassy in Israel from Tel Aviv, breaking with decades of established US policy and international practice. https://cnn.it/2IkRU02",
                "The Israeli army air-dropped leaflets over Gaza warning people not to approach the fence that separates Gaza from Israel.",
                "Border Patrol counted 5,984 deaths of people crossing illegally in the border region over a 16-year period. But a CNN investigation found at least 564 people who died but weren’t counted.",
                "Is a nice stroll enough to confer the life-saving benefits we know come from exercise? We posed the question to five specialists in the field.",
                "It's the first time WHO is calling for the elimination of something other than a noncommunicable disease.",
                "Hockey moms united this Mother's Day for the mothers in Canada who lost their children in the Humboldt Broncos bus crash, sending them virtual hugs and bouquets.",
                "Leaked audio from from one of Pastor John Hagee's sermons in the 1990s seemed to suggest that Adolf Hitler had been fulfilling God's will by aiding the desire of Jews to return to Israel, while Pastor Robert Jeffress has said that Mormons, Muslims and Hindus worship a false god.",
                "Iran's Foreign minister will also meet with representatives from Germany, France and the United Kingdom to discuss the future of the nuclear deal, after Donald J. Trump announced that the US would be withdrawing from it.",
                "It's a historic step in the country's mission to build a navy capable of rivaling the world's leading maritime powers",
                "The National Rifle Association says Governor Andrew Cuomo and a state agency have coerced banks and insurance companies to withhold services to the gun lobbying group",
                "Today, the Trump administration will move the US embassy in Israel to Jerusalem"
            };

            // Apply TF*IDF to the documents and get the resulting vectors.
            int length = documents.Length;
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
            double control_value = 0.6/(length / (Math.Sqrt(words.Count*length)));
            Console.WriteLine("contol value" + control_value);
            foreach (var word in words)
            {
                if (vocab[word] < control_value)
                    Console.WriteLine(vocab[word] + " " + word);
            }
            
            Console.WriteLine("Press any key ..");
            Console.ReadKey();
        }
    }
}
