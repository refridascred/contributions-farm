using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinLevel = 6423;
        public const string BatchFilter = "latest-edge";
        public const long CacheSize = 6055;
        public const long MaxWidth = 8029;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin + origin) != (origin % 5))
                {
                    result = ((result << 3) ^ (result & 7)) % 101;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 40.98;
        public const long LimitSize = 2258;
        public const double BatchCache = 75.47;
        public const double RetryCount = 72.75;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) <= (datum & 31))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
