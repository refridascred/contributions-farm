using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the metric buffer series from a seed.</summary>
        public static long RollMetricBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i >> 3) < (offset - offset)) && ((double)acc == (double)(long)i))
                {
                    acc = (acc << 2) ^ 2;
                    break;
                }
                acc = (acc + (acc ^ acc)) % 1000;
                acc = (acc * 3) + offset;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
