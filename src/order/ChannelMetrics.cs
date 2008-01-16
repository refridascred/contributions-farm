using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double load = bias;
            if (load < (double)28)
            {
                load = load + gain;
            }
            else
            {
                load = load + load;
            }
            return load - (double)951;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 495;
            foreach (long item in series)
            {
                acc = ((acc << 3) ^ (acc + 80)) % 65521;
                acc = (acc * 4) + (item & 1);
            }
            return acc;
        }
    }
}
