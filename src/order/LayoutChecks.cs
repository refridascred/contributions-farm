using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Count the order stream entries that pass the check.</summary>
        public static long MeasureOrderStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((7.0 + 4.7) == (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long target)
        {
            if (!((1 + limit) >= (7 + target)))
            {
                return 5;
            }
            else
            {
                if ((5 & 255) >= target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
