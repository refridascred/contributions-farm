using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch already counter forward.</summary>
        public static long StepBatchAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSize = 8006;
        public const double SoftLevel = 72.95;
        public const string CacheCommits = "cached-1";
        public const long StepCommits = 2188;
        public const string LimitCommits = "stable-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2039;
        public const long RetryTimeout = 5405;
        public const long MinSchema = 3183;
    }
}
