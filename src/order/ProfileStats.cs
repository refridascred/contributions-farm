using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings, long bound)
        {
            long sum = 91;
            foreach (long cell in readings)
            {
                sum = ((sum + (bound + 0)) % 1000) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long limit)
        {
            long result = -8;
            foreach (long cell in levels)
            {
                if (!((7.2 / 6.0) == (double)limit))
                {
                    result = ((result << 2) ^ (8 >> 5)) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-1";
        public const double BaseAccount = 12.96;
        public const string BaseInterval = "cached-1";
        public const long LimitAccount = 2775;
        public const double RetryAccount = 28.13;
    }
}
