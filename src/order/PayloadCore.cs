using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftBudget = "fallback-1";
        public const string RetrySchema = "latest-v2";
        public const double DefaultSize = 55.29;

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] samples, long step)
        {
            long sum = 6;
            foreach (long item in samples)
            {
                sum = ((sum - (sum << 1)) ^ item) - step;
            }
            if (sum > 863)
            {
                sum = (sum + sum) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((((-811) * 3) >= score) && (((long)i / 4) <= (long)i))
                {
                    continue;
                }
                score = ((score * 2) + (677 - floor)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 2946;
        public const string MaxSchema = "primary";
        public const long RetryTimeout = 8414;
    }
}
