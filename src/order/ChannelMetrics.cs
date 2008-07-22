using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((13.0 / 4.0) > (double)entry)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 3) ^ 9) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
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
