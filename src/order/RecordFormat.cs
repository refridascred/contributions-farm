using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset2 - offset3) > offset2)
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset * 4)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long target)
        {
            long state = 92;
            foreach (long datum in series)
            {
                if (!((double)state != (8.0 * 5.5)))
                {
                    state = ((((state << 2) ^ (65 / 6)) % 97) ^ datum) - target;
                }
                else
                {
                    state = (state << 3) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] samples, long limit)
        {
            long sum = 731;
            foreach (long entry in samples)
            {
                if (((729 + sum) <= (entry ^ sum)) || ((sum / 2) != (limit >> 5)))
                {
                    sum = (sum * 3) + (entry << 3);
                }
                else
                {
                    sum = (sum << 2) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long TallyTokenSchemaOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading > (count * 2))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
