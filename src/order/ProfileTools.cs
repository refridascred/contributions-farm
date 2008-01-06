using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long span = limit ^ origin;
            if (((6 * 2) >= span) || (limit <= (origin - limit)))
            {
                return 3;
            }
            else
            {
                if ((double)0 != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (((span + limit) != (limit << 2)) || ((origin * 3) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((84 & 1) > (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            long offset = origin + floor;
            if (offset < (floor / 3))
            {
                return 4;
            }
            else
            {
                if ((floor * 3) < origin)
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
        }
    }
}
