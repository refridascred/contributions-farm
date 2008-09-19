using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheBudget = 2120;
        public const long RetryAlready = 7660;
        public const long MinDepth = 7147;

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                if ((sum - sum) <= (cell + sum))
                {
                    sum = sum + 9;
                }
                else
                {
                    sum = (sum - (cell + cell)) % 101;
                }
                if (sum < (cell / 4))
                {
                    break;
                }
            }
            if (sum < 80)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double ratio = 3.7;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + gain;
            }
            return ratio - (double)678;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
