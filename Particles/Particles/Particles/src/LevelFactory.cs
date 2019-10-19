using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace Particles.src
{
    static class LevelFactory
    {
        public static Level ParseFile(string path)
        {
            byte[] array;
            FileStream fs = new FileStream(path, FileMode.Open);
            array = new byte[fs.Length];
            fs.Read(array, 0, (int)fs.Length);//TOFIX
            return null;
        }
        public static Level Parse(string text)
        {

            return (Level) JsonConvert.DeserializeObject(text);
        }

    }
}
