using GBX.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GbxTest
{
    public static class Misc
    {
        public static bool TextToInt3(string text, out Int3 conversion)
        {
            conversion = default;
            text = text.Replace(" ", string.Empty);
            string[] split = text.Split(',');
            if (split.Length != 3) return false;
            int[] xyz = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                bool canConvert = int.TryParse(split[i], out int num);
                if (canConvert)
                    xyz[i] = num;
                else
                    return false;
            }
            conversion = new Int3(xyz[0], xyz[1], xyz[2]);
            return true;
        }

        public static bool Int3ToText(Int3 coord, out string conversion)
        {
            conversion = string.Format("{0},{1},{2}", coord.X, coord.Y, coord.Z);
            return true;
        }
    }
}
