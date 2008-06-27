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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 3) > (reading / 2))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
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
