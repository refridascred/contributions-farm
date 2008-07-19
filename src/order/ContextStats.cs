using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = (floor - floor) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 4.0) + (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSpan = 80.46;
        public const string MinSession = "latest";
        public const long LimitSession = 9660;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the buffer entry entries that pass the check.</summary>
        public static long AuditBufferEntryHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length - 273) <= (count ^ item))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
