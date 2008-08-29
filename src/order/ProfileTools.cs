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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long target)
        {
            if ((origin % 5) != (target ^ 7))
            {
                return 7;
            }
            else
            {
                if ((double)target > (10.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
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
