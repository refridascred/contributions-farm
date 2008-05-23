using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstScore = 4158;
        public const long HardRatio = 3040;
        public const string DefaultLevel = "standard";

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(5 <= (count * 5)))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-9) ^ count) >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
