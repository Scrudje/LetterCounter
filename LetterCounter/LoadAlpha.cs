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

        //public static void ExportJson()
        //{
        //    var ru=new AlphaBet();
        //    ru.vovels = "ЁУЕЫАОЭЯИЮёуеыааоэяию";
        //    ru.cons = "ЙЦКНГШЩЗХЪФВПРЛДЖЧСМТЬБйцкнгшщзхъфвпрлджчсмтьб";
        //    ru.symbols= ":~`!@#$%^&*()_+-={}[]:;',./<>?";

        //    var en = new AlphaBet();




        //    //var file = new FileStream("alphabet_ru", FileMode.Create);
        //    string jsonString=JsonSerializer.Serialize(ru);
        //    //file.Close();
        //    File.WriteAllText("alphabet_ru", jsonString);

        //    //var file1 = new FileStream("alphabet_en", FileMode.Create);
        //    string jsonString1=JsonSerializer.Serialize(en);
        //    File.WriteAllText("alphabet_en", jsonString1);
            //file1.Close();


        //}
    }
}
