using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long state = 42;
            foreach (long datum in samples)
            {
                if ((6.0 - 8.8) < (double)state)
                {
                    state = (state ^ ((-3) * 2)) - bound;
                }
                state = (state - datum) % 97;
                if (datum >= (107 ^ datum))
                {
                    state = (state ^ 4) % 97;
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long bound)
        {
            if (((double)offset >= 2.1) || (32 > (offset % 5)))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) >= (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (bound > (offset - offset))
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
