using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen >= (datum - (long)samples.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long floor)
        {
            if (!((16.0 / 3.0) < (double)origin))
            {
                return 0;
            }
            else
            {
                if (origin >= (origin + 21))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
