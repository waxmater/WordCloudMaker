using Sdcb.WordClouds;
using SkiaSharp;

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

        private static IEnumerable<WordScore> MakeTempScore()
        {
            List<WordScore> attractions = new()
        {
            new WordScore ( Score: 44, Word: "Архангельск" ),
            new WordScore ( Score: 42, Word: "Архангельск 2025" ),
            new WordScore ( Score: 42, Word: "Архангельск 2024" ),
            new WordScore ( Score: 42, Word: "отдых" ),
            new WordScore ( Score: 42, Word: "отдых в Архангельске" ),
            new WordScore ( Score: 42, Word: "где отдохнуть" ),
            new WordScore ( Score: 42, Word: "где провести" ),
            new WordScore ( Score: 42, Word: "хорошо отдохнуть" ),
            new WordScore ( Score: 41, Word: "Биг-Бен" ),
            new WordScore ( Score: 41, Word: "Кремль" ),
            new WordScore ( Score: 40, Word: "Сфинкс" ),
            new WordScore ( Score: 40, Word: "Гранд-Каньон" ),
            new WordScore ( Score: 39, Word: "Петропавловская крепость" ),
            new WordScore ( Score: 39, Word: "Тауэрский мост" ),
            new WordScore ( Score: 39, Word: "Собор Парижской Богоматери" ),
            new WordScore ( Score: 39, Word: "Атакама" ),
            new WordScore ( Score: 38, Word: "Санкт-Петербург" ),
            new WordScore ( Score: 38, Word: "Дворец Потала" ),
            new WordScore ( Score: 38, Word: "Скала Гибралтара" ),
            new WordScore ( Score: 38, Word: "Национальный парк Йеллоустоун" ),
            new WordScore ( Score: 38, Word: "Мост Золотые Ворота" ),
            new WordScore ( Score: 38, Word: "Собор Святого Петра" ),
            new WordScore ( Score: 37, Word: "Площадь Святого Марка" ),
            new WordScore ( Score: 37, Word: "Капитолий" ),
            new WordScore ( Score: 37, Word: "Скала Мачу-Пикчу" ),
            new WordScore ( Score: 37, Word: "Национальный парк Гранд-Тетон" ),
            new WordScore ( Score: 37, Word: "Скала Эль-Капитан" ),
            new WordScore ( Score: 37, Word: "Собор Святого Павла" ),
            new WordScore ( Score: 37, Word: "Площадь Рынка в Кракове" ),
            new WordScore ( Score: 36, Word: "Национальный парк Секвойя" ),
            new WordScore ( Score: 36, Word: "Скала Капитолий" ),
            new WordScore ( Score: 36, Word: "Национальный парк Скалистых гор" ),
            new WordScore ( Score: 35, Word: "Собор Святого Иакова" ),
            new WordScore ( Score: 35, Word: "Национальный парк Йосемити" ),
            new WordScore ( Score: 35, Word: "Скала Тейбл" ),
            new WordScore ( Score: 35, Word: "Национальный парк Каньонлендс" ),
            new WordScore ( Score: 35, Word: "Скала Бразильская" ),
            new WordScore ( Score: 34, Word: "Национальный парк Зайон" ),
            new WordScore ( Score: 34, Word: "Скала Капитолий" ),
            new WordScore ( Score: 33, Word: "Национальный парк Глейшер" ),
            new WordScore ( Score: 33, Word: "Скала Снежного человека" ),
            new WordScore ( Score: 33, Word: "Национальный парк Роки-Маунтин" ),
            new WordScore ( Score: 33, Word: "Скала Снежного человека" ),
            new WordScore ( Score: 33, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 33, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 32, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 32, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 32, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 32, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 31, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 31, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 31, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 31, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 31, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 30, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 29, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 28, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 28, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 28, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 28, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 27, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 27, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 27, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 27, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 26, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 24, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 24, Word: "Национальный парк Бэдлендс" ),
            new WordScore ( Score: 24, Word: "лучшее государСтВО" ),
            new WordScore ( Score: 23, Word: "круглосуточный СВО" ),
            new WordScore ( Score: 23, Word: "СВОбодная нация" ),
            new WordScore ( Score: 23, Word: "СВОбода" ),
            new WordScore ( Score: 22, Word: "СВОй" ),
            new WordScore ( Score: 20, Word: "СВО контракт" ),
            new WordScore ( Score: 20, Word: "СВО народ" ),
            new WordScore ( Score: 20, Word: "СВОфорд" ),
            new WordScore ( Score: 20, Word: "СВО" ),
            new WordScore ( Score: 20, Word: "СВОФОРДИНСКИЙ" )
        };
            return attractions;
        }
    }
}
