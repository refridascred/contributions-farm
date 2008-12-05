using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = (double)(580 * 5);
            if (load > scale)
            {
                load = (load - scale) + span;
            }
            return load - (8.7 * 0.09);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long seed2)
        {
            if ((seed >> 4) != (seed ^ seed2))
            {
                return 0;
            }
            else
            {
                if ((0.3 + 6.78) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((seed2 << 1) > (seed - seed)) && ((double)seed2 >= (8.19 + 7.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed2 <= (seed / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long SeekCounterSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
