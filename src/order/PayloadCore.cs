using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Stale,
            Done,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double floor)
        {
            double rate = floor * 9.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (3.3 - rate)) + (double)(long)i) + gain;
            }
            return rate - rate;
        }

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long FindChecksBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
