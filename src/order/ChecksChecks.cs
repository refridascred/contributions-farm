using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer metrics entries that pass the check.</summary>
        public static long AuditBufferMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)749 <= (double)matches)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a context report reading.</summary>
        public static double BlendContextReport(double gain, double floor)
        {
            double weight = gain / 8.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + floor;
        }
    }
}
