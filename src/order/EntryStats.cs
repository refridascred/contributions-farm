using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((offset - offset) != (64 / 7)) && ((state ^ 65) == (585 << 1)))
                {
                    state = ((state * 5) + (offset / 9)) % 101;
                }
                state = (state << 3) ^ (offset + (-88));
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a batches metrics sample.</summary>
        public static long LocateBatchesMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 4585;
        public const long IdleCount = 3857;
        public const double SoftRatio = 86.33;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Done,
            Locked,
            Paused,
            Dropped,
        }
    }
}
