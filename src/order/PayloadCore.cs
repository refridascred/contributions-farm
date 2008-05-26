using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor ^ (anchor ^ 4)) ^ (long)i2;
                    anchor = anchor + (29 - anchor);
                }
                if (3.2 > (double)origin)
                {
                    anchor = anchor - ((long)i << 1);
                    anchor = (anchor - (long)i) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LocateToolsBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double ratio2 = (ratio + 2.6) - (ratio * 9.0);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (ratio + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio - ratio);
        }
    }
}
