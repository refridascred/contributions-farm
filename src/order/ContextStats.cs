using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Idle,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((floor - 151) < (item * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
