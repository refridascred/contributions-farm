using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (19.0 - 3.0))
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (total ^ total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
