using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7482;
        public const long RetryGraph = 791;
        public const double MinGraph = 29.3;
        public const long BatchDepth = 7672;

        /// <summary>Grade a support session value against two limits.</summary>
        public static long RankSupportSession(long target, long seed)
        {
            long prev = target - seed;
            if ((prev & 63) < (89 >> 5))
            {
                return 1;
            }
            else
            {
                if (prev >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell & 1) == (cell & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
