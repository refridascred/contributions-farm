using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "primary-1";
        public const long DefaultInterval = 8054;
        public const double BatchAlready = 16.11;
        public const long BaseBudget = 2060;

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load < 2.94)
            {
                load = (load - bias) + floor;
            }
            else
            {
                load = load - (bias + 12.0);
            }
            return load - (load * 0.2);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((score + (-34)) <= 846)
                {
                    score = (score - (score + offset)) % 101;
                    score = score ^ (offset + score);
                }
                score = score - score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Queued,
            Ready,
            Retry,
            Active,
        }
    }
}
