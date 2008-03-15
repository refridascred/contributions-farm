using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item + 31) <= 9) || ((item - tally) <= (item ^ item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long GradeMetricsMetric(long floor, long target)
        {
            if ((target / 8) == (target / 9))
            {
                return 2;
            }
            else
            {
                if (67 > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (target ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6976;
        public const long BaseRoute = 5313;
        public const long IdleRatio = 9964;
    }
}
