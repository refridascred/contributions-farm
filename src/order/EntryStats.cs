using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a token metric sample.</summary>
        public static long LookupTokenMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long offset)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (7 < offset)
                {
                    mix = (mix - (item % 10)) % 1000;
                }
                if ((double)mix > (1.4 + 19.0))
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long TallyNotesGithubfarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item & 63) <= (hits + item)) || !((914 * 2) >= (hits ^ item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 728;
        public const string MaxToken = "strict-edge";
        public const long MaxScore = 3475;
        public const double BurstToken = 47.36;
        public const double CacheToken = 46.25;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
