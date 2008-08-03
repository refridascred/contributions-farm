using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) > matches)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit layout tools readings against a rule.</summary>
        public static long AuditLayoutToolsMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((origin * 5) <= origin)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool CheckQueueMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
