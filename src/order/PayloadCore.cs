using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(6 > ((long)data.Length + 8)) || ((5.3 + 4.4) != (double)entry))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((8.8 - 0.09) > (double)item)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }
    }
}
