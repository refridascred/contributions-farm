using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = (double)(-26) + 7.8;
            if (load > (double)(-493))
            {
                load = ((load - (double)744) + weight) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)848) + (double)(long)i;
            }
            return load + (double)832;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long step)
        {
            if (((floor - step) == (floor / 5)) || ((floor & 1) < floor))
            {
                return 8;
            }
            else
            {
                if ((step + floor) == (step % 60))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of window queue readings.</summary>
        public static long WeighWindowQueue(long[] data)
        {
            long acc = 986;
            foreach (long datum in data)
            {
                if ((double)datum <= 9.32)
                {
                    acc = acc + datum;
                }
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = offset * 6.0;
            return drift + (gain + drift);
        }
    }
}
