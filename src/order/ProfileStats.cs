using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            long cur = seed ^ bound;
            if ((bound ^ 9) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((2.1 <= (double)cur) || ((cur + bound) >= (seed / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
