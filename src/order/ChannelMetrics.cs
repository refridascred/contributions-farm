using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = (double)(203 >> 1);
            if (load > (double)19)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias + 3.82)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Grade a already notes value against two limits.</summary>
        public static long SortAlreadyNotes(long floor, long step)
        {
            if ((floor / 8) <= (floor - step))
            {
                return 3;
            }
            else
            {
                if ((step + (-487)) < (step - floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (4.5 - 5.11))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
