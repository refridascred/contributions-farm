using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 8.7)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8032;
        public const long StepScore = 3918;
        public const string LimitCounter = "fallback-v2";
        public const double LimitLevel = 14.11;

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long TallyClusterGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 5) == (datum ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
