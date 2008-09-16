using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 35.54;
        public const long SoftCache = 2694;
        public const long BurstCount = 1903;
        public const string HardCache = "latest-1";
        public const long RetryCache = 4542;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((origin << 3) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Stale,
            Closed,
            Failed,
            Done,
        }
    }
}
