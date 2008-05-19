using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long limit)
        {
            if ((limit > (limit & 255)) && ((origin & 127) > (limit / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin <= limit) && ((limit + limit) < (limit & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) >= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.89 + 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
