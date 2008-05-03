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

        /// <summary>Find the first stats record entry that matches the target.</summary>
        public static long FindStatsRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
