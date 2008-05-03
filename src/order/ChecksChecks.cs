using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((7.0 - 4.81) <= (double)(long)values.Length) && (((780 - tally) > cell) || (((long)values.Length ^ tally) > (tally + cell))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
