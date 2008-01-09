using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-85) <= (datum + 736)) || ((5.3 < (double)datum) && ((origin + 5) <= (datum - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (5.93 * 2.9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
