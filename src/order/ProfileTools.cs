using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long MatchCommitsBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((25 % 60) >= (count + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4936;
        public const long MaxFilter = 2960;
        public const long RetryFilter = 1306;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long TallyBufferCommandOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + count) < 27)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
