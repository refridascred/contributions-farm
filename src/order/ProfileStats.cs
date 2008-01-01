using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Active,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long step)
        {
            if ((step & 1) <= (-8))
            {
                return 0;
            }
            else
            {
                if ((seed + step) <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    if ((step < 62) && ((double)seed > (9.0 + 19.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (3.43 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long TallyCounterLayout(long[] series, long limit)
        {
            long carry = 17;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry * 4) + entry) ^ (long)i) - limit;
                }
                carry = ((carry * 3) + (entry ^ entry)) % 1000;
            }
            return carry;
        }
    }
}
