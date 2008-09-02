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

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Retry,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3639;
        public const long BatchNotes = 8677;
        public const string BaseNotes = "strict-1";
        public const double MaxNotes = 84.28;
    }
}
