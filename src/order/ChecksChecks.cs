using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((8.56 * 1.0) > (double)state) && (37 > state))
                {
                    state = ((state << 2) ^ (30 >> 5)) % 255;
                    state = (state - state) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            if ((double)step <= (double)9)
            {
                return 7;
            }
            else
            {
                if ((double)limit >= 1.73)
                {
                    return 3;
                }
                else
                {
                    if ((step * 2) == (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ limit) == (step & 15))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
