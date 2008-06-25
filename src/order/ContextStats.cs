using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metric tools counter forward.</summary>
        public static long SeriesMetricTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                long lane = mix * 5;
                if (lane >= mix)
                {
                    mix = mix ^ (0 - lane);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double rate = (double)(4 % 12);
            return (rate + gain) + offset;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
