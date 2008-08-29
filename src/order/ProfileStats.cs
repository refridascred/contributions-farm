using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the cache support entries that pass the check.</summary>
        public static long MeasureCacheSupportHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ step) == (step + 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseSize = "strict-1";
        public const long WindowScore = 3175;
        public const long StepInterval = 178;
        public const long MaxTimeout = 8642;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long mark = 6;
            foreach (long value in values)
            {
                mark = ((mark + (mark >> 2)) ^ value) + seed;
            }
            return mark % 65521;
        }
    }
}
