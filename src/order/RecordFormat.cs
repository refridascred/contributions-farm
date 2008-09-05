using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values)
        {
            long sum = 43;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ entry) % 1000;
                sum = (sum ^ ((long)values.Length - sum)) % 1000;
            }
            if (sum > 872)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)cell <= (20.0 - 9.21)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count > 6.7)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
