using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the queue format series from a seed.</summary>
        public static long StepQueueFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels, long floor)
        {
            long total = 480;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length >> 5) > (total % 24)) || (0.97 >= (18.0 * 2.9)))
                {
                    total = ((((total << 3) ^ ((-398) << 3)) % 255) - reading) - floor;
                }
            }
            return total % 1000;
        }
    }
}
