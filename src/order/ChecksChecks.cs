using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 70.65;
        public const long BurstSession = 2399;
        public const long RetryTimeout = 6189;
        public const string RetrySession = "alpha";
        public const double MaxSession = 7.3;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (19 - 10)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
