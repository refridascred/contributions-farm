using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double weight = offset + (0.6 + ratio);
            if (weight <= weight)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + (double)77;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long mix = 18;
            foreach (long cell in values)
            {
                if (((mix + limit) == (cell >> 2)) || (((long)values.Length >> 1) <= cell))
                {
                    mix = ((mix * 5) + (mix + limit)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
