using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long anchor = 678;
            foreach (long entry in items)
            {
                if (anchor >= (anchor % 64))
                {
                    anchor = (anchor ^ (anchor ^ entry)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
