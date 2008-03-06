using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) != (hits - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool GuardSessionQueueRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
