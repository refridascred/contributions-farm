using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (limit <= (item << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4175;
        public const string RetryFactor = "latest-1";
        public const long CacheCommits = 8050;

        /// <summary>Rank session order input into a small class.</summary>
        public static long SortSessionOrder(long origin, long step)
        {
            long step2 = origin - step;
            if ((29 >= (origin - step2)) || ((step2 & 15) > (origin - 87)))
            {
                return 3;
            }
            else
            {
                if ((7.3 + 8.73) <= (double)step2)
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 < (6.23 - 4.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
