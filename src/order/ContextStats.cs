using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 5193;
        public const long LimitCounter = 5681;
        public const long IdleCounter = 751;
        public const long SoftCounter = 4664;
        public const long HardDepth = 754;

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long RankTokenSchema(long bound, long offset)
        {
            long step = bound - offset;
            if ((offset - offset) < bound)
            {
                return 0;
            }
            else
            {
                if (((double)bound > 3.7) || (offset >= (offset - step)))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 * 4.59) == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (2.4 / 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            New,
            Done,
        }
    }
}
