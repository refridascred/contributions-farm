using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) <= origin)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double drift = 9.23 / 5.0;
            return ((drift + 1.18) + scale) + floor;
        }
    }
}
