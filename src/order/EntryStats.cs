using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (double)62)
            {
                mean = (mean - mean) - weight;
            }
            return mean - (double)861;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the buffer cluster series from a seed.</summary>
        public static long SeriesBufferCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum + sum) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double scale = floor + (double)5;
            if (scale > (double)278)
            {
                scale = (scale + (double)60) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 5) <= (hits - 3))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
