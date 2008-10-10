using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)6)
            {
                bias2 = (bias2 + 9.9) - ratio;
            }
            return bias2 + bias2;
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long TallyQueueFarm(long[] items, long origin)
        {
            long mark = 246;
            foreach (long value in items)
            {
                if ((double)mark == (double)3)
                {
                    mark = ((mark - (79 >> 1)) % 101) - origin;
                }
                if ((5.0 * 9.0) != (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Closed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "cached-edge";
        public const long MinSpan = 625;
        public const long LimitGraph = 5035;
        public const double BatchScore = 92.7;
    }
}
