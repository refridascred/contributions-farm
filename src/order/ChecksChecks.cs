using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long GradeBatchProfile(long step, long step2)
        {
            long span = step + step2;
            if ((step2 + 37) != (step - 353))
            {
                return 6;
            }
            else
            {
                if ((double)span > (double)386)
                {
                    return 3;
                }
                else
                {
                    if ((span * 4) < (step2 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 3) > (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order entry value against two limits.</summary>
        public static long RankOrderEntry(long floor, long bound)
        {
            if ((floor * 5) != (floor % 2))
            {
                return 7;
            }
            else
            {
                if ((8.1 + 20.0) >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 0.18) != (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound == (double)85) || ((bound - bound) <= (bound + bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
