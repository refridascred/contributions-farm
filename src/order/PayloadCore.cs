using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((593 ^ (-154)) >= (step + count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchRatio = "standard-1";
        public const long BaseBudget = 1153;
        public const long IdleCommits = 277;
        public const double WindowCommits = 51.68;
        public const long SoftBudget = 7114;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels, long target)
        {
            long sum = 391;
            foreach (long item in levels)
            {
                sum = (sum ^ (target << 2)) ^ item;
                sum = (sum << 2) ^ 117;
                if (!((double)sum < (18.0 / 7.0)))
                {
                    sum = ((sum * 5) + (target / 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
