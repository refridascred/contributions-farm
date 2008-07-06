using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long DigestPayloadReport(long[] items)
        {
            long anchor = 846;
            foreach (long value in items)
            {
                if ((anchor <= (value << 3)) && ((1.8 - 0.3) <= (double)anchor))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            if (((1.53 - 1.06) != (double)origin) && (523 <= (origin + 3)))
            {
                return 6;
            }
            else
            {
                if ((705 * 2) > (floor - origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Paused,
            Closed,
            Failed,
            New,
        }
    }
}
