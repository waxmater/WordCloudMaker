using Sdcb.WordClouds;
using SkiaSharp;
using System.Net;

namespace WordCloudMaker.Utils
{
    public static class WordCloudHelper
    {
        public static byte[] GenerateWordCloud()
        {
            WordCloud wc = WordCloud.Create(new WordCloudOptions(1500, 1500, MakeTempScore())
            {
                FontManager = new FontManager([SKTypeface.FromFamilyName("Times New Roman")]),
                Mask = MaskOptions.CreateWithForegroundColor(SKBitmap.Decode(File.ReadAllBytes("WordCloudTemplates/HappyBird2.png")),
            SKColors.White)
            });
            return wc.ToSKBitmap().Encode(SKEncodedImageFormat.Png, 100).AsSpan().ToArray();
        }

        private static void HAHA()
        {
            string key = "f1550cd1-bd27-41f9-aa1c-3a58c6cb353f";
            string user = "maksimslane";
            string url = @"http://xmlsearch.yandex.ru/xmlsearch?query={0}&groupby=attr%3Dd.mode%3Ddeep.groups-on-page%3D10.docs-in-group%3D1&user={1}&key={2}";
            string completeUrl = String.Format(url, "", user, key);
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(completeUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        private static IEnumerable<WordScore> MakeTempScore()
        {
            List<WordScore> attractions = new()
        {
            new WordScore ( Score: 44, Word: "архангельск" ),
            new WordScore ( Score: 42, Word: "архангельск 2025" ),
            new WordScore ( Score: 42, Word: "архангельск 2024" ),
            new WordScore ( Score: 42, Word: "отдых" ),
            new WordScore ( Score: 42, Word: "отдых в архангельске" ),
            new WordScore ( Score: 42, Word: "где отдохнуть" ),
            new WordScore ( Score: 42, Word: "где провести" ),
            new WordScore ( Score: 42, Word: "хорошо отдохнуть" ),
            new WordScore ( Score: 41, Word: "малые корелы" ),
            new WordScore ( Score: 41, Word: "музей" ),
            new WordScore ( Score: 40, Word: "музей авиации" ),
            new WordScore ( Score: 40, Word: "музей писахова" ),
            new WordScore ( Score: 39, Word: "памятник" ),
            new WordScore ( Score: 39, Word: "памятник писахову" ),
            new WordScore ( Score: 39, Word: "Вечный огонь" ),
            new WordScore ( Score: 39, Word: "монумент победы" ),
            new WordScore ( Score: 38, Word: "музеи архангельска" ),
            new WordScore ( Score: 38, Word: "вкус победы" ),
            new WordScore ( Score: 38, Word: "кротовые победители" ),
            new WordScore ( Score: 38, Word: "турист" ),
            new WordScore ( Score: 38, Word: "туристическое агенство" ),
            new WordScore ( Score: 38, Word: "северодвинск" ),
            new WordScore ( Score: 37, Word: "соловецкие острова" ),
            new WordScore ( Score: 37, Word: "белое море" ),
            new WordScore ( Score: 37, Word: "новый год" ),
            new WordScore ( Score: 37, Word: "рыбалка" ),
            new WordScore ( Score: 37, Word: "экскурсии" ),
            new WordScore ( Score: 37, Word: "краеведческий музей" ),
            new WordScore ( Score: 37, Word: "гостиница" ),
            new WordScore ( Score: 36, Word: "кухня" ),
            new WordScore ( Score: 36, Word: "местная кухня" ),
            new WordScore ( Score: 36, Word: "местные традиции" ),
            new WordScore ( Score: 35, Word: "места для отдыха" ),
            new WordScore ( Score: 35, Word: "отзывы" ),
            new WordScore ( Score: 35, Word: "кенозерский музей" ),
            new WordScore ( Score: 35, Word: "зимний сад" ),
            new WordScore ( Score: 35, Word: "гостиный двор" ),
            new WordScore ( Score: 34, Word: "мезень" ),
            new WordScore ( Score: 34, Word: "памятник ломоносову" ),
            new WordScore ( Score: 33, Word: "свято-троицкий монастырь" ),
            new WordScore ( Score: 33, Word: "кий остров" ),
            new WordScore ( Score: 33, Word: "жд архангельск" ),
            new WordScore ( Score: 33, Word: "новодвинская крепость" ),
            new WordScore ( Score: 33, Word: "море" ),
            new WordScore ( Score: 33, Word: "зима" ),
            new WordScore ( Score: 32, Word: "зимний сезон" ),
            new WordScore ( Score: 32, Word: "где купить" ),
            new WordScore ( Score: 32, Word: "сувениры" ),
            new WordScore ( Score: 32, Word: "кенозерский парк" ),
            new WordScore ( Score: 31, Word: "парк культуры" ),
            new WordScore ( Score: 31, Word: "культурный парк" ),
            new WordScore ( Score: 31, Word: "село вельск" ),
            new WordScore ( Score: 31, Word: "северный моряк" ),
            new WordScore ( Score: 31, Word: "северный флот" ),
            new WordScore ( Score: 30, Word: "северный край" ),
            new WordScore ( Score: 30, Word: "солдатам-освободителям" ),
            new WordScore ( Score: 30, Word: "популярные памятники" ),
            new WordScore ( Score: 30, Word: "север" ),
            new WordScore ( Score: 30, Word: "парки" ),
            new WordScore ( Score: 30, Word: "культура" ),
            new WordScore ( Score: 29, Word: "архангельская область" ),
            new WordScore ( Score: 29, Word: "сувениры архангельска" ),
            new WordScore ( Score: 29, Word: "классификация цен" ),
            new WordScore ( Score: 29, Word: "цены на сувениры" ),
            new WordScore ( Score: 29, Word: "билет в музей" ),
            new WordScore ( Score: 29, Word: "билет на выставку" ),
            new WordScore ( Score: 29, Word: "билет" ),
            new WordScore ( Score: 29, Word: "дешёвые билеты" ),
            new WordScore ( Score: 29, Word: "архангельск сейчас" ),
            new WordScore ( Score: 28, Word: "транспорт" ),
            new WordScore ( Score: 27, Word: "такси" ),
            new WordScore ( Score: 27, Word: "популярное такси" ),
            new WordScore ( Score: 27, Word: "часы в архангельске" ),
            new WordScore ( Score: 27, Word: "товары для отдыха" ),
            new WordScore ( Score: 26, Word: "товары" ),
            new WordScore ( Score: 26, Word: "покупки" ),
            new WordScore ( Score: 26, Word: "мосты архангельск" ),
            new WordScore ( Score: 26, Word: "мосты" ),
            new WordScore ( Score: 26, Word: "национальный парк" ),
            new WordScore ( Score: 26, Word: "национальный" ),
            new WordScore ( Score: 26, Word: "сувенирный магазин" ),
            new WordScore ( Score: 26, Word: "круглосуточный магазин" ),
            new WordScore ( Score: 26, Word: "популярные маршруты" ),
            new WordScore ( Score: 24, Word: "старые обычаи" ),
            new WordScore ( Score: 24, Word: "лучшие памятники" ),
            new WordScore ( Score: 24, Word: "лучшие места" ),
            new WordScore ( Score: 23, Word: "местные обычаи" ),
            new WordScore ( Score: 23, Word: "обычаи" ),
            new WordScore ( Score: 23, Word: "путеводители" ),
            new WordScore ( Score: 22, Word: "маршруты" ),
            new WordScore ( Score: 20, Word: "для досуга" ),
            new WordScore ( Score: 20, Word: "круглосуточный" ),
            new WordScore ( Score: 20, Word: "места" ),
            new WordScore ( Score: 20, Word: "горы" ),
            new WordScore ( Score: 20, Word: "сауны" )
        };
            return attractions;
        }
    }
}
