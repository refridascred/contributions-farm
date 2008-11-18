using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen < (seen * 5))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((689 + bound) != (203 & 1))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
