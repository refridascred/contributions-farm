using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long bound)
        {
            long acc = 386;
            foreach (long reading in levels)
            {
                acc = acc + (bound << 3);
                if (((20.0 + 6.3) < (double)reading) && ((double)acc < 3.3))
                {
                    acc = (acc - (bound ^ bound)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
