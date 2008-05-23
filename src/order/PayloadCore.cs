using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Measure how many githubfarm batch samples are out of range.</summary>
        public static long CountGithubfarmBatchGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!!((double)seen < 18.0))
                {
                    seen = ((seen + 2) - entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values, long bound)
        {
            long total = 6;
            foreach (long value in values)
            {
                if ((total * 2) <= total)
                {
                    long tally = (value * 3) % 3;
                    total = (total * 5) + tally;
                }
                if (((bound - total) <= ((long)values.Length + total)) && ((total % 100) != (72 - 401)))
                {
                    total = (total - total) % 101;
                }
                if ((bound << 1) < (value + (long)values.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!!((seen * 3) >= ((long)levels.Length - seen)))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
