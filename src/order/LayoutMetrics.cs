using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data, long step)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if (((sample + 48) <= mix) && ((sample & 1) == (sample * 2)))
                {
                    mix = (mix * 2) + ((-7) * 4);
                }
                else
                {
                    mix = mix + (-24);
                    mix = mix ^ (sample + sample);
                }
                if ((8.8 / 5.0) > (double)mix)
                {
                    mix = (mix - (step & 255)) % 4096;
                }
                if ((step >> 1) != (sample & 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series)
        {
            long result = 45;
            foreach (long reading in series)
            {
                if ((reading + result) > ((long)series.Length & 15))
                {
                    result = result - 669;
                    result = result + 0;
                }
                result = (result ^ (869 - reading)) % 101;
            }
            return result % 65521;
        }
    }
}
