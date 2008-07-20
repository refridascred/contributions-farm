using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell > (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long step)
        {
            long gap = limit + step;
            if (!(limit > (limit % 5)))
            {
                return 3;
            }
            else
            {
                if ((double)gap == (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((limit % 97) >= 11)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 6499;
        public const string BaseCommits = "latest-v2";
        public const long MaxWidth = 115;
        public const long WindowCommits = 9892;
        public const double RetryInterval = 49.53;
    }
}
