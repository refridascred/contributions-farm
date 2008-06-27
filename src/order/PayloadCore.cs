using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "fallback";
        public const string MinEntry = "latest-v2";
        public const double BurstRatio = 13.87;
        public const long MaxScore = 2885;
        public const long MaxEntry = 3922;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > 16)
                {
                    tally = ((tally + 1) ^ cell) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((782 - hits) == (bound << 2)) || ((double)bound >= 3.2)) && ((double)240 < (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long TotalClusterEntry(long[] readings, long step)
        {
            long mix = 13;
            foreach (long entry in readings)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 4096;
                if (((mix >> 4) != ((long)readings.Length * 2)) || (160 < (mix + entry)))
                {
                    mix = mix - (step + entry);
                }
            }
            return mix % 97;
        }
    }
}
