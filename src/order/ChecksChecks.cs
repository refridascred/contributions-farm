using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinDepth = 1707;
        public const long CachePayload = 4541;
        public const long CacheSize = 2519;
        public const long LimitWidth = 7717;

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen < (double)datum)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "alpha-edge";
        public const double MinTools = 82.8;
        public const double MaxSize = 93.87;
    }
}
