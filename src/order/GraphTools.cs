using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next batches window value from a seed.</summary>
        public static long DeriveBatchesWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor - (step * 5)) % 101;
                anchor = ((anchor << 2) ^ ((long)i % 2)) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            New,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Dropped,
            Closed,
            Paused,
            Locked,
        }
    }
}
