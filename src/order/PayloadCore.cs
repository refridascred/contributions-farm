using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a route session figure with a bias.</summary>
        public static double AdjustRouteSession(double bias, double span)
        {
            double scale = (bias / 5.0) * 6.0;
            if (scale <= 4.8)
            {
                scale = scale + 3.1;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (5.0 * 6.0)) - (double)(long)i;
            }
            return scale - (span + 18.0);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample < (76 ^ tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
