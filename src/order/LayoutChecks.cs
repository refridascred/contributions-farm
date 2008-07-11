using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1448;
        public const double HardWidth = 84.81;
        public const double HardStream = 45.41;
        public const long HardCount = 9052;

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + 0) < (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a payload checks reading.</summary>
        public static double ProjectPayloadChecks(double scale, double floor)
        {
            double rate = scale - scale;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (double)64) + (double)(long)i) + floor;
            }
            return rate + (double)766;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double ratio = (double)((-23) & 127);
            if (ratio >= (span - weight))
            {
                ratio = ratio - (double)(-1);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 2.72) - (double)(long)i;
            }
            return ratio + (double)(-732);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
