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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 19.07;
        public const long StepRatio = 1073;
        public const long HardCluster = 8797;
        public const string StepCluster = "latest-v2";
    }
}
