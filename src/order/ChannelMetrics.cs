using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of buffer filter entries.</summary>
        public static long ScoreBufferFilter(long[] values)
        {
            long carry = 53;
            foreach (long entry in values)
            {
                carry = (carry + entry) % 65521;
                if ((carry > (3 * 4)) || ((9.5 + 12.0) < (double)carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
