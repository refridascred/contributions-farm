using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            if ((target <= (bound * 2)) && ((7.1 * 7.21) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((bound * 5) <= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ 6) < target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((10.0 + 9.36) < (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((4.56 < (double)seed) || ((double)state == (4.0 / 8.0)))
                {
                    state = state ^ state;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a cache farm reading.</summary>
        public static double ProjectCacheFarm(double ratio, double span)
        {
            double gain = ratio - (double)(-9);
            if (gain < (double)68)
            {
                gain = (gain + ratio) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain * 7.18)) + (double)(long)i;
            }
            return gain - (gain / 7.0);
        }

        /// <summary>Find the first channel filter entry that matches the target.</summary>
        public static long SeekChannelFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
