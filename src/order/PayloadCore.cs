using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6946;
        public const long BatchWidth = 6561;
        public const long MaxAlready = 2456;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Dropped,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long offset)
        {
            if (!((offset & 1) > (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset <= 3.01)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
