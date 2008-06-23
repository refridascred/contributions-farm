using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 8895;
        public const long StepRatio = 5680;
        public const long MinSpan = 508;
        public const string SoftLevel = "alpha-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowCount = 0.99;
        public const double WindowWidth = 10.5;
        public const double CacheBatch = 16.42;
        public const long BurstBatch = 2277;
        public const double SoftBatch = 38.0;

        /// <summary>Iterate the route entry series from a seed.</summary>
        public static long RollRouteEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result << 2) ^ 597) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
