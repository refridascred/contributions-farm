using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((total / 4) < (target + target))
                {
                    total = (total + (1 + target)) % 4096;
                }
                total = ((total * 5) + total) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Token { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
