using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long seed)
        {
            if ((seed + step) != (seed >> 3))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (5.12 * 7.16)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double load = (double)(35 & 3);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + bias) + (double)(long)i) - floor;
            }
            return load - load;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
