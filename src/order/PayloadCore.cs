using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long state = 55;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state ^ (cell - state)) % 97) + (long)i;
                }
                if (((double)(long)items.Length >= (double)cell) || ((433 + cell) > cell))
                {
                    state = (state - (cell - cell)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long anchor = 303;
            foreach (long cell in items)
            {
                anchor = (anchor - (51 + cell)) % 1000;
            }
            if (anchor > 95)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 8309;
        public const double BaseScore = 17.48;
        public const long StepTools = 8720;
        public const double MaxTools = 63.9;
        public const long SoftTools = 6527;
    }
}
