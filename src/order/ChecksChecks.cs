using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "local-v2";
        public const long RetryDepth = 7763;
        public const long WindowChannel = 1088;
        public const string BaseBudget = "primary";
        public const long CacheChannel = 5660;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(((double)count <= 5.8) && ((count << 3) > (limit + limit))))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
