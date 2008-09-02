using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 3) ^ (total + target);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
