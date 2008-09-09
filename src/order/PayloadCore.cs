using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = result ^ (result ^ result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric stream measurements.</summary>
        public static double ProjectMetricStream(double bias, double floor)
        {
            double gain = floor;
            if (gain < (floor / 3.0))
            {
                gain = (gain + (double)4) - bias;
            }
            return gain + gain;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
