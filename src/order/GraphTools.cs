using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepDepth = 3823;
        public const string CacheFilter = "cached-v2";
        public const string IdleFilter = "open-v2";
        public const string StepFilter = "alpha-1";
        public const double MaxLevel = 39.07;

        /// <summary>Derive the next counter metric value from a seed.</summary>
        public static long DeriveCounterMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ anchor;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor << 2) ^ (origin + anchor)) % 97) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
