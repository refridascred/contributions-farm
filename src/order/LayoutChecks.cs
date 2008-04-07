using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepBudget = "strict-edge";
        public const long DefaultInterval = 8093;
        public const string RetryAlready = "local-v2";
        public const double MaxDepth = 96.95;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long result = 887;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - 545) ^ (long)i;
                    result = result ^ result;
                }
                result = (result * 3) + result;
                if ((result << 2) > (8 - result))
                {
                    result = result + (entry * 3);
                }
                if ((1.6 * 16.0) == (double)entry)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ (129 / 8)) + item;
                total = (total - (total + target)) % 65521;
                if ((total >= target) && (total < (target - total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "fallback-v2";
        public const long BatchCount = 6079;
        public const long RetryCount = 9304;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleTimeout = 7456;
        public const double LimitSupport = 62.94;
        public const double BurstLevel = 87.06;
        public const long BatchSupport = 6121;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 8015;
        public const long IdleBudget = 630;
        public const double SoftFactor = 1.54;
        public const long CacheRatio = 2529;
    }
}
