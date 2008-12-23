using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if (score >= (floor + (-51)))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double mean = span / 6.0;
            if (mean > span)
            {
                mean = mean + 9.42;
            }
            else
            {
                mean = mean + (span + 5.6);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span + span)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 31) < (tally << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
