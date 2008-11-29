using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Paused,
            Idle,
            New,
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long OverlapBufferCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
