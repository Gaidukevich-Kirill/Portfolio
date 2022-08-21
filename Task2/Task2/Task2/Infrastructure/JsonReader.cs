﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Task2.Products;

namespace Task2.Infrastructure
{
    public static class JsonReader<T>
    {
        public static void JsonReadFromFileBrick(out List<T> listBricks, string path)
        {
            var sw = new StreamReader(path);

            var informationOfObject = sw.ReadToEnd();
            listBricks = JsonConvert.DeserializeObject<List<T>>(informationOfObject);
            sw.Close();
        }
    }
}
