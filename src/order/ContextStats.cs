using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor >> 3) < (floor - floor))
                {
                    acc = acc - floor;
                }
                else
                {
                    acc = acc ^ (floor - acc);
                }
                acc = ((acc * 5) + (floor % 64)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
