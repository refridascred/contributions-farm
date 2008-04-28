using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 6194;
        public const string BatchContributi = "stable";
        public const long MinLevel = 8912;

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long MeasureGithubfarmContextMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((bound ^ cell) >= bound)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.4 - 0.44) >= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
