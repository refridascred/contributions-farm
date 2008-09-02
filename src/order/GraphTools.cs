using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Synced,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = drift - (gain / 9.0);
            }
            else
            {
                drift = drift - 8.12;
            }
            return drift - gain;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double load = offset;
            if (load >= (load + bias))
            {
                load = load - (double)76;
            }
            return load - (load / 3.0);
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
