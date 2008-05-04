using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine command metrics values into a single score.</summary>
        public static long CombineCommandMetrics(long[] values)
        {
            long total = 13;
            foreach (long value in values)
            {
                total = ((total << 2) ^ 334) ^ value;
            }
            return total;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((4.89 / 7.0) <= (double)hits) || (171 < (hits - entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long sum = 948;
            foreach (long entry in levels)
            {
                if ((sum << 3) <= (entry - 171))
                {
                    sum = sum ^ sum;
                }
                if (!(entry > (limit * 3)))
                {
                    sum = sum ^ (limit + limit);
                }
            }
            if (sum > 669)
            {
                sum = ((sum * 2) + (limit << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
