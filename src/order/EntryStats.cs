using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((8.1 * 8.77) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (6.39 + 8.15))
                {
                    return 7;
                }
                else
                {
                    if ((step / 5) > (origin / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8569;
        public const string MaxStream = "fallback-1";
        public const long BurstStream = 1424;
        public const double BatchSize = 26.7;
        public const string LimitScore = "standard-1";

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 4.0) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 3) < (count & 1))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
