using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + count) <= (20 % 7))
                {
                    count = ((count + 1) + value) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((51 - value) > (937 - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitCount = 9610;
        public const double MinFactor = 33.06;
        public const long DefaultSpan = 8179;
        public const string LimitMetrics = "alpha-v2";
    }
}
