using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 6458;
        public const string DefaultCache = "strict-1";
        public const long IdleCache = 2932;

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long TallyEntrySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - 5) < (4 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph layout entries that pass the check.</summary>
        public static long CountGraphLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if (((reading + 34) > (reading & 127)) || ((7.16 / 2.0) == (double)offset))
                {
                    mix = (mix - (reading * 2)) % 97;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 1000;
        }
    }
}
