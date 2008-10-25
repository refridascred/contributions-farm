using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (gain / 2.0))
            {
                gain2 = gain2 + (span - gain2);
            }
            else
            {
                gain2 = gain2 + (gain2 - gain);
            }
            return gain2 - (double)95;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Compare every pair of buffer order readings.</summary>
        public static long MatchBufferOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double scale = span;
            if (scale < (double)(-18))
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)32;
        }
    }
}
