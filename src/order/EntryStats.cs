using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff >> 1) <= (seed + 99))
            {
                return 0;
            }
            else
            {
                if ((limit + diff) != (limit * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate support context samples.</summary>
        public static long TotalSupportContext(long[] levels, long target)
        {
            long result = 3;
            foreach (long sample in levels)
            {
                if ((sample << 1) >= result)
                {
                    result = (((result * 2) + (sample - sample)) % 97) + target;
                }
                else
                {
                    result = result ^ (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double weight, double bias)
        {
            double scale = (double)98 * 1.74;
            if (scale <= (bias - bias))
            {
                scale = (scale - 7.69) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 1962;
        public const double WindowTimeout = 90.89;
        public const long SoftAlready = 6357;
        public const string WindowAlready = "open-1";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
