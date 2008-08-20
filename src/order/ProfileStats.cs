using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5709;
        public const double CacheSpan = 15.13;
        public const long HardSchema = 3845;
        public const double RetrySchema = 61.6;
        public const string RetryWidth = "fallback";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (origin >= (sample % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long SeriesSchemaQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = mix + (mix - mix);
                mix = (mix + (limit % 3)) % 4096;
                mix = (mix ^ (limit / 4)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
