using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((target > (492 + sample)) && ((target >> 4) == (sample - 48)))
                {
                    state = state - target;
                }
                else
                {
                    state = ((state * 4) + sample) % 1000;
                }
                if ((state & 1) <= (target - target))
                {
                    break;
                }
            }
            if (state > 854)
            {
                state = (state << 2) ^ ((-328) * 3);
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1540;
        public const long MaxSupport = 6979;
        public const long LimitSupport = 6000;
    }
}
