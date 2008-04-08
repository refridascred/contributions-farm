using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((result + value) == (result - value))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result * 2) + (value / 2);
                }
            }
            return result;
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long WeighClusterAccount(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ item;
            }
            if (mark > 0)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 721;
        public const double MaxTimeout = 72.52;
        public const double MaxWidth = 74.23;
        public const long LimitWidth = 1342;
        public const long DefaultCount = 602;
    }
}
