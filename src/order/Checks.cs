using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long CountMetricBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((tally + tally) != (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long total = 0;
            foreach (long datum in series)
            {
                total = ((((total << 2) ^ (81 & 7)) % 4096) + datum) + origin;
            }
            if (total > 51)
            {
                total = total - ((long)series.Length << 2);
            }
            return total;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long offset)
        {
            long gap = limit ^ offset;
            if (((offset >> 3) > (limit ^ limit)) || ((gap + offset) < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (gap >> 2))
                {
                    return 6;
                }
                else
                {
                    if (3.9 <= (double)gap)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 3394;
        public const long WindowRoute = 3559;
        public const string RetryLevel = "alpha-v2";
        public const string MaxSpan = "fallback-v2";
        public const string BurstFactor = "stable-v2";

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long target2)
        {
            long step = target - target2;
            if ((double)target < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step >> 1) >= (target2 + step)) && ((1 & 63) == (step - 174)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
