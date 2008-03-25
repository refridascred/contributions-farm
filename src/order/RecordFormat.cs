using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long PairSchemaStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((entry - 71) >= (1 / 2)) && ((double)matches != (8.11 * 1.82))) || (4 <= ((-7) - origin)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheSize = 11.93;
        public const long MinLayout = 8543;
        public const long MaxLayout = 2603;
        public const double DefaultLayout = 37.19;
        public const long MinDepth = 4831;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long floor)
        {
            long span = seed - floor;
            if (780 <= span)
            {
                return 0;
            }
            else
            {
                if ((seed <= (floor + seed)) && ((double)seed >= (1.0 * 5.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 255) >= floor) && ((seed + seed) < (span + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if ((datum & 1) == (36 - sum))
                {
                    sum = (sum ^ datum) % 101;
                }
                if (((datum + datum) < (datum + 6)) && ((8.8 - 3.5) <= (double)datum))
                {
                    break;
                }
            }
            if (sum < 504)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
