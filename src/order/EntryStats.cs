using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Derive the next token metric value from a seed.</summary>
        public static long IterateTokenMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score <= 812) || (((long)i & 63) >= (score << 1)))
                {
                    score = score - step;
                    score = ((score << 2) ^ (step << 2)) % 101;
                }
                if (step < (0 + (long)i))
                {
                    score = ((score << 3) ^ step) % 101;
                }
                else
                {
                    score = (score * 3) + step;
                    score = ((score << 2) ^ 777) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Ready,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 91.71;
        public const string RetryProfile = "primary";
        public const long BaseProfile = 4870;

        /// <summary>Look up the position of a support session sample.</summary>
        public static long FindSupportSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
