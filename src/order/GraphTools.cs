using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 5373;
        public const long BaseCache = 5784;
        public const double BatchSize = 57.72;
        public const long DefaultCache = 2876;
        public const long IdleCache = 9053;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
