using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long anchor = 37;
            foreach (long item in readings)
            {
                anchor = (anchor * 2) + (item % 16);
                if (!(7.53 < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > (-3))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
