using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double gain, double bias)
        {
            double scale = bias + (bias * 3.6);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - 6.5) + (double)(long)i) + gain;
            }
            return scale + 19.0;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Synced,
        }
    }
}
