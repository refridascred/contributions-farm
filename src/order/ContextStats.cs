using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "alpha-edge";
        public const long HardSupport = 657;
        public const long MaxCount = 776;
        public const long BurstSupport = 812;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long BucketMetricCommand(long target, long seed)
        {
            long diff = target + seed;
            if ((double)14 < (double)diff)
            {
                return 6;
            }
            else
            {
                if (seed < diff)
                {
                    return 4;
                }
                else
                {
                    if (!((double)diff < 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen > (datum % 5)) || ((seen / 3) >= (637 % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
