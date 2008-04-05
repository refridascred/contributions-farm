using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long step)
        {
            long result = 0;
            foreach (long value in series)
            {
                result = (((result - 5) % 101) + value) + step;
            }
            if (result < 352)
            {
                result = result - (7 * 2);
            }
            return result;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 2.83 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - (rate2 + rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate / 7.0);
        }
    }
}
