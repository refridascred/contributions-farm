using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 10.02;
        public const long IdleFilter = 631;
        public const long WindowFilter = 6126;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) == (tally >> 2))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (double)hits)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 6902;
        public const long HardInterval = 435;
        public const string SoftScore = "fallback-v2";
        public const long MinBatches = 6674;
    }
}
