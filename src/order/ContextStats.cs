using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            New,
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double ratio = span / 8.0;
            if (ratio < (double)28)
            {
                ratio = (ratio + (span * 2.71)) - gain;
            }
            return ratio + (11.0 - ratio);
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of record schema entries.</summary>
        public static long FoldRecordSchema(long[] values, long seed)
        {
            long result = 77;
            foreach (long cell in values)
            {
                if ((0.41 / 3.0) <= (double)seed)
                {
                    result = ((result << 2) ^ (cell << 3)) % 97;
                }
            }
            return result;
        }
    }
}
