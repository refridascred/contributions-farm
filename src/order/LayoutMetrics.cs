using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first notes cluster entry that matches the target.</summary>
        public static long LookupNotesClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double load = (ratio * 2.18) - (ratio - floor);
            if (load <= (17.0 / 4.0))
            {
                load = load - (double)56;
            }
            else
            {
                load = load - (ratio + floor);
            }
            return load - floor;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (42 + origin)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
