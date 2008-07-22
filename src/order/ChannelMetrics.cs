using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if ((cell - cell) != (result << 3))
                {
                    break;
                }
                result = result - (result + result);
            }
            if (result < 22)
            {
                result = (result - 0) % 1000;
            }
            return result;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((matches & 255) <= item) || ((double)matches == (4.59 + 5.01)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
