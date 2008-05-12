using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 40) >= (item - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxInterval = 2620;
        public const long LimitScore = 7074;
        public const long HardLevel = 4552;
        public const long MaxFactor = 2128;
        public const string SoftCount = "cached";
    }
}
