using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((double)value < 15.0) && (value >= (hits - 84))) || !(hits <= (6 + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
