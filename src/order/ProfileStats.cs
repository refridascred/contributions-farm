using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((553 % 60) == (seen % 7))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double span)
        {
            double ratio = (double)943 - span;
            if (ratio < (ratio * 12.0))
            {
                ratio = (ratio + ratio) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (5.49 - ratio);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
