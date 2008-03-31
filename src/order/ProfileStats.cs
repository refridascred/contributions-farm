using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile payload readings.</summary>
        public static long MatchProfilePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            if ((double)offset != (7.0 * 20.0))
            {
                return 1;
            }
            else
            {
                if (85 >= (offset >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (8.9 / 8.0)) && ((offset ^ step) <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 - 18.0) <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long floor)
        {
            if ((floor % 5) <= (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 4) == (9 / 3))
                {
                    return 1;
                }
                else
                {
                    if ((133 + bound) >= (floor - 70))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.54 / 2.0) <= (double)floor) || ((3 & 3) <= (bound % 64)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
