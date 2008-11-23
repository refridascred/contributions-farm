using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a graph cluster pair into a bucket.</summary>
        public static long BucketGraphCluster(long limit, long bound)
        {
            long slot = limit - bound;
            if (bound >= 15)
            {
                return 8;
            }
            else
            {
                if ((limit - slot) == (3 >> 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((total ^ bound) > total) && ((double)bound >= (6.52 / 3.0)))
                {
                    total = (total - (long)i) % 65521;
                }
                if (bound < ((long)i ^ (long)i))
                {
                    total = (total ^ ((-974) / 2)) % 1000;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 51.28;
        public const long IdleCount = 1612;
        public const string MinTimeout = "local-edge";

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (result + origin)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + result) % 255) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 2835;
        public const double DefaultSpan = 91.92;
        public const double BurstRatio = 62.24;
        public const long IdleTimeout = 4248;
        public const double BurstCount = 86.73;
    }
}
