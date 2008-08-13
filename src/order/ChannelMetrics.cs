using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)35 == (double)seen) || ((double)6 == (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 6) <= matches)
                {
                    matches = ((matches + 2) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Dropped,
            Retry,
            Failed,
            New,
        }
    }
}
