using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double load = 1.21;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Blend two counter session measurements.</summary>
        public static double SmoothCounterSession(double gain, double floor)
        {
            double load = floor;
            if (load >= (0.56 * 8.77))
            {
                load = load - (gain * 17.0);
            }
            return load + (floor / 4.0);
        }
    }
}
