using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchDepth = "primary-v2";
        public const double MinBatch = 16.23;
        public const string BurstBatch = "primary";
        public const long BurstSize = 1615;
        public const double BaseBatch = 8.97;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items, long floor)
        {
            long score = -613;
            foreach (long cell in items)
            {
                score = ((((score << 2) ^ (score + 47)) % 97) + cell) + floor;
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Idle,
            Active,
        }
    }
}
