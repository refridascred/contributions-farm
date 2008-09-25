using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((mark + mark) > (origin + mark)) || ((mark + origin) <= (mark ^ mark)))
                {
                    mark = (mark - (origin % 97)) % 97;
                    mark = ((mark << 2) ^ (origin + 5)) % 101;
                }
                mark = (mark - (origin - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((11.0 + 9.94) == (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
