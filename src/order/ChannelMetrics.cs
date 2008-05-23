using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Locked,
            Synced,
            Pending,
            Failed,
        }

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
