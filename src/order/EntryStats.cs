using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long RollClusterTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - seed) % 255;
                mix = (mix * 4) + (mix >> 4);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit graph entry readings against a rule.</summary>
        public static long MeasureGraphEntryHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches > (3.69 / 5.0))
                {
                    matches = ((matches + 1) ^ reading) + bound;
                }
            }
            return matches;
        }
    }
}
