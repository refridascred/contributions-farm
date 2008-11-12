using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] levels, long limit)
        {
            long mark = 67;
            foreach (long sample in levels)
            {
                if ((limit * 5) > sample)
                {
                    mark = mark ^ (limit / 3);
                }
                mark = (mark - (sample % 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            New,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if (floor <= step)
            {
                return 6;
            }
            else
            {
                if (!((step / 9) <= (7 - floor)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (step & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 > (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.94 * 7.9) <= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
