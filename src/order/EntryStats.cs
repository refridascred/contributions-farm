using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8674;
        public const long LimitSchema = 4610;
        public const long IdleSchema = 2593;
        public const long HardCount = 625;
        public const long WindowSchema = 246;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double offset)
        {
            double ratio = (offset + rate) * 3.6;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 1.3)) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double floor)
        {
            double ratio = scale / 2.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.1 + scale)) + (double)(long)i;
            }
            return ratio - (floor - 4.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6606;
        public const long BaseAccount = 9858;
        public const string MinSpan = "open-edge";
    }
}
