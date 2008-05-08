using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen < (datum * 3)) || ((double)datum < 8.6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 44.74;
        public const double MaxGithubfarm = 1.48;
        public const long WindowSize = 4943;
        public const long SoftRatio = 1567;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings, long floor)
        {
            long mark = 970;
            foreach (long entry in readings)
            {
                mark = (((mark * 4) + entry) % 97) - floor;
            }
            return mark;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long seed)
        {
            if ((4.64 / 9.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((double)limit != (double)seed) || ((7.6 / 7.0) >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) > (limit ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - seed) != (seed ^ 991))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
