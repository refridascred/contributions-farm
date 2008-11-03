using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double load = (2.9 + offset) * 20.0;
            if (load <= (offset / 5.0))
            {
                load = load - rate;
            }
            else
            {
                load = load + offset;
            }
            return load - (rate * 18.0);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Pending,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5352;
        public const long RetryCount = 5162;
        public const long LimitWidth = 961;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((target * 4) <= (count << 1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
