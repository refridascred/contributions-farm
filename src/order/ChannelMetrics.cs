using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((7.3 - 10.0) < (double)hits)
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long carry = 869;
            foreach (long reading in series)
            {
                carry = (((carry + (402 * 4)) % 1000) - reading) - origin;
            }
            return carry % 1000;
        }
    }
}
