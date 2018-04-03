using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using labamobilki2.ViewModel;
using System.Reflection;
using labamobilki2.Model;

namespace labamobilki2.Parsers
{
    public class JSONParser
    {
        private string FileName = "data.json";

        private string GetJson()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;

            Stream stream = assembly.GetManifestResourceStream($"labamobilki2.Parsers.{FileName}");

            string taskJson;

            using (var reader = new StreamReader(stream))
            {
                taskJson = reader.ReadToEnd();
            }

            return taskJson;
        }

        public VMMainList GetData()
        {
            /*
            var json = GetJson();

            if (json == null)
            {
                return null;
            }

            var filmsData = JObject.Parse(json);

            var list = JsonConvert.DeserializeObject<T>(filmsData.ToString());
            List<VMMain> resultList = new List<VMMain>();
            foreach (var elem in list)
            {
                resultList.Add(new VMMain(elem));
            }
            VMMainList totalList = new VMMainList();
            totalList.Elements = resultList;
            return totalList;
             */
            return null;
        }
    }
}
