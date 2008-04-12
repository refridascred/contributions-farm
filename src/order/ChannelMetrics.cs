using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((long)values.Length < (tally + 78))
                {
                    tally = ((tally + 2) + value) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }
    }
}
