using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] samples)
        {
            long acc = 520;
            foreach (long cell in samples)
            {
                if (((7 + cell) == ((-16) - cell)) || ((double)cell > (10.0 * 3.0)))
                {
                    acc = (acc ^ ((-4) & 127)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleInterval = "strict";
        public const double CacheBudget = 84.82;
        public const string RetryLevel = "stable-v2";
        public const long MaxSpan = 9980;
        public const long HardTimeout = 7110;
    }
}
