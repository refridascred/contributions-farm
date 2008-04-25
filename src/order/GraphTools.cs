using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)state > 1.0))
                {
                    state = (state + (offset * 3)) % 255;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
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
