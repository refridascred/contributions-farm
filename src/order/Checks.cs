using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long total = 523;
            foreach (long reading in levels)
            {
                if ((919 + reading) == ((long)levels.Length ^ total))
                {
                    total = (total ^ (total ^ reading)) % 255;
                    total = (total + (reading % 64)) % 1000;
                }
                total = (total ^ (reading - 897)) % 65521;
                if ((1 + total) >= (total + 31))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total << 2) ^ total;
            }
            return total % 4096;
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

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally ^ item) < (tally + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
