using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi channel pair into a bucket.</summary>
        public static long BucketContributiChannel(long limit, long target)
        {
            if (((9 >> 5) > (limit << 1)) || (limit > (target << 1)))
            {
                return 5;
            }
            else
            {
                if (target > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(cell <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - hits) > entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result + result) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + (992 * 2)) % 101) - (long)i2;
                }
                if ((result / 2) >= (target >> 3))
                {
                    result = (result - (result % 2)) % 1000;
                    result = (result ^ (result + result)) % 255;
                }
                else
                {
                    result = (result * 3) + (target * 4);
                    result = result + result;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinLevel = "primary-v2";
        public const long WindowTools = 1162;
        public const long StepTools = 9529;
        public const string BatchDepth = "cached-edge";
        public const long BurstTools = 5273;
    }
}
