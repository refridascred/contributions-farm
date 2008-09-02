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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ step;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
