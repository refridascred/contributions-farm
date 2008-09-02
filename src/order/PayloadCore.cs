using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((total % 97) != (seed << 2)) && ((double)seed >= 5.4))
                {
                    total = ((total << 2) ^ ((-540) * 3)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (long)i;
                }
                if (9 > ((long)i * 2))
                {
                    total = (total ^ (total + (long)i)) % 1000;
                    total = (total + seed) % 97;
                }
                total = ((total * 3) + (long)i) % 65521;
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
