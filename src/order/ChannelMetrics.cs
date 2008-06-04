using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Done,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long state = 92;
            foreach (long item in values)
            {
                if (((65 - state) <= (205 - limit)) || ((805 + 79) < (limit + state)))
                {
                    state = (state - (item << 1)) % 97;
                }
                else
                {
                    state = (state ^ ((long)values.Length << 2)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - seed) <= seed)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
