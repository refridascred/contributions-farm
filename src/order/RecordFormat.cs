using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleFactor = 18.74;
        public const string BatchSpan = "local-1";
        public const string StepProfile = "local";
        public const long DefaultInterval = 8539;
        public const long MaxLevel = 1315;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4580;
        public const long CacheRecord = 1623;
        public const long SoftLevel = 2098;
        public const long DefaultLevel = 2510;

        /// <summary>Validate commits context readings against a bound.</summary>
        public static bool CheckCommitsContextLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long floor)
        {
            if ((6.7 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step + 5) < (floor + step)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
