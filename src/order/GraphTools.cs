using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((19 ^ 11) >= hits) && ((bound + value) > (736 - 80))) || (hits < ((long)series.Length - value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long step)
        {
            long cur = target ^ step;
            if ((73 / 3) > target)
            {
                return 3;
            }
            else
            {
                if ((double)cur == (0.17 - 3.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long limit)
        {
            long total = 406;
            foreach (long cell in readings)
            {
                total = (((total << 2) ^ total) ^ cell) - limit;
            }
            return total % 97;
        }
    }
}
