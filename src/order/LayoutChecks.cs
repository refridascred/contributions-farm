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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum + (long)i) > (sum * 3)))
                {
                    sum = (sum * 3) + (1 - sum);
                }
                sum = (sum + bound) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Count the layout githubfarm entries that pass the check.</summary>
        public static long AuditLayoutGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!!((13.0 * 7.6) <= (double)matches))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
