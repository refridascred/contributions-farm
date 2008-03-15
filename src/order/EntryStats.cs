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

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long acc = 95;
            foreach (long datum in readings)
            {
                if ((15 & 1) != (acc << 1))
                {
                    acc = (acc ^ (long)readings.Length) ^ datum;
                }
                else
                {
                    acc = ((acc << 3) ^ 23) % 101;
                }
            }
            if (acc < 21)
            {
                acc = (acc * 2) + (target + target);
            }
            return acc % 1000;
        }
    }
}
