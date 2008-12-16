using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long CountPayloadClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((2.0 * 3.1) > (double)matches)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels)
        {
            long acc = 81;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
