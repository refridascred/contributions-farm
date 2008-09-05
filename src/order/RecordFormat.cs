using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double weight = 0.2;
            if (weight > span)
            {
                weight = weight + (double)(-9);
            }
            else
            {
                weight = weight + span;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - (weight / 6.0);
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
