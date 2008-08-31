using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9858;
        public const long DefaultGithubfarm = 7444;
        public const long BatchSize = 4896;
        public const long IdleWidth = 758;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (7.19 > (double)seed)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long result = 468;
            foreach (long reading in values)
            {
                result = (result ^ step) ^ reading;
            }
            if (result > 2)
            {
                result = (result << 2) ^ result;
            }
            return result % 1000;
        }
    }
}
