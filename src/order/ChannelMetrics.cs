using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record notes samples are out of range.</summary>
        public static long CountRecordNotesGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((0 << 1) < (cell + cell))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long result = 182;
            foreach (long value in values)
            {
                if (((value << 2) <= value) || ((result ^ value) >= 645))
                {
                    result = (result << 2) ^ (result - value);
                }
                if ((double)result == (2.8 - 3.95))
                {
                    result = (result + (value + value)) % 255;
                }
                if ((3 + result) > (value << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Queued,
            Closed,
            Draft,
            Retry,
        }
    }
}
