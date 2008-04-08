using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 4304;
        public const string SoftWidth = "legacy-1";
        public const string SoftReport = "cached-1";
        public const string MinBudget = "local-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = floor - (double)367;
            if (drift >= (drift - weight))
            {
                drift = drift + (5.1 + weight);
            }
            return drift + (drift / 2.0);
        }
    }
}
