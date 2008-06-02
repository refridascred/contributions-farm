using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Draft,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double scale = (5.9 * 6.6) * 3.33;
            if (scale >= (double)3)
            {
                scale = ((scale + (double)44) - ratio) + bias;
            }
            else
            {
                scale = scale + (double)(-479);
            }
            return scale + scale;
        }

        /// <summary>Audit schema support readings against a rule.</summary>
        public static long TallySchemaSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
