using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound >> 5) != (bound + bound))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches cache entries.</summary>
        public static long WeighBatchesCache(long[] samples, long target)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                if ((datum * 5) <= (total % 97))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total << 3) ^ (target >> 2)) % 65521;
            }
            if (total < 55)
            {
                total = ((total << 3) ^ target) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long limit)
        {
            if (((target >> 5) > limit) || ((double)limit >= 9.7))
            {
                return 6;
            }
            else
            {
                if (((target & 127) == (target >> 1)) && (6.93 < (double)target))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (limit << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
