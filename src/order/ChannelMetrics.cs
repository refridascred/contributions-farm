using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitRatio = 78.24;
        public const string WindowSize = "alpha-edge";
        public const double BaseLevel = 74.92;
        public const string HardProfile = "latest-edge";
        public const string BatchFactor = "legacy";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-78) + 7) <= tally)
                {
                    tally = ((tally + 1) ^ item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
