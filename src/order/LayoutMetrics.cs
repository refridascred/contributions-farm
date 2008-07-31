using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long acc = 287;
            foreach (long value in samples)
            {
                if (((2.8 / 2.0) >= (double)value) && ((value >> 5) <= (value - acc)))
                {
                    acc = acc - (acc + value);
                }
                else
                {
                    acc = ((acc << 2) ^ (value & 7)) % 4096;
                }
                if (acc >= (acc + value))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
