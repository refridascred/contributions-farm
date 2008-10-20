using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double ratio = (double)(8 >> 2);
            for (int i = 0; i < 8; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) + scale) - span;
            }
            return ratio - (double)17;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((cell & 15) >= (778 & 7)) || ((double)cell < (4.1 - 5.74)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Draft,
            Locked,
            Failed,
        }
    }
}
