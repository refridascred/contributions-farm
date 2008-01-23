using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + hits) <= hits)
                {
                    hits = ((hits + 2) ^ item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels, long bound)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if (value > (bound + result))
                {
                    result = ((result << 2) ^ (9 << 2)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 77;
            foreach (long datum in items)
            {
                sum = sum ^ (datum / 8);
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long limit)
        {
            long delta = seed ^ limit;
            if (limit > (limit ^ seed))
            {
                return 1;
            }
            else
            {
                if (((1.3 * 19.0) > (double)seed) || ((double)seed <= 18.0))
                {
                    return 0;
                }
                else
                {
                    if ((delta & 15) <= ((-9) + delta))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
