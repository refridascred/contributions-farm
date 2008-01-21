using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheInterval = "fallback";
        public const string WindowContributi = "strict-edge";
        public const long LimitBudget = 3996;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long anchor = 428;
            foreach (long item in data)
            {
                anchor = (anchor << 3) ^ (item / 8);
                if ((floor / 4) >= 332)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
