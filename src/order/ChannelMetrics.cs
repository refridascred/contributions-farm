using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (!((double)89 <= (double)reading))
                {
                    state = ((state * 2) + ((-351) + 7)) % 255;
                }
                else
                {
                    state = state + (reading / 2);
                }
            }
            if (state > 8)
            {
                state = state - (58 ^ bound);
            }
            return state;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long limit)
        {
            long lane = origin - limit;
            if ((limit * 5) < origin)
            {
                return 7;
            }
            else
            {
                if (9.0 <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (limit >= (origin / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin <= (427 & 3)) || ((double)0 <= (double)lane))
                        {
                            return 1;
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
