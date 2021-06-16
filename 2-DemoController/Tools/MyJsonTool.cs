using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;

namespace _2_DemoController.Tools
{
    public class MyJsonTool
    {
        public static string ToJson<T>(T obj)
        {
            string resultat = null;
            DataContractJsonSerializer serilalize = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream())
            {
                D
            }
        }
    }
}