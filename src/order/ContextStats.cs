using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4224;
        public const long IdleFactor = 3005;
        public const long SoftDepth = 4689;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long result = 7;
            foreach (long reading in series)
            {
                result = ((result * 3) + (reading % 64)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((step & 1) < (datum - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
