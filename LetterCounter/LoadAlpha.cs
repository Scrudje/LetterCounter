using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace LetterCounter
{
    public static class LoadAlpha
    {
        public static AlphaBet Load(string lang)
        { 
            var newAlpha=new AlphaBet();
            switch (lang) 
            {
                case "RU": newAlpha= ImportJson("alphabet_ru.json");
                    break;
                case "EN": newAlpha= ImportJson("alphabet_en.json");
                    break;
                default:break;
            }

            return newAlpha;
        }
        private static AlphaBet ImportJson(string path)
        {
            var alpha = new AlphaBet();
            switch (path)
            {
                
                case "alphabet_ru.json":
                    alpha.vovels = "ЁУЕЫАОЭЯИЮёуеыааоэяию";
                    alpha.cons = "ЙЦКНГШЩЗХЪФВПРЛДЖЧСМТЬБйцкнгшщзхъфвпрлджчсмтьб";
                    alpha.symbols = ":~`!@#$%^&*()_+-={}[]:;',./<>?";
                    break;
                case "alphabet_en.json":
                    alpha.vovels = "EYUIOAeyuioa";
                    alpha.cons = "QWRTPSDFGHJKLZXCVBNMqwrtpsdfghjklzxcvbnm";
                    alpha.symbols= ":~`!@#$%^&*()_+-={}[]:;',./<>?";
                    break;
                default: break;

            }

            return alpha;

            //var file = new FileStream(path, FileMode.Open);
            //return JsonSerializer.DeserializeAsync<AlphaBet>(file).Result;
            //file.Close();
        }

       
    }
}
