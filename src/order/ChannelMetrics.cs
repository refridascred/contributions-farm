using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long acc = 698;
            foreach (long item in levels)
            {
                acc = acc ^ (item + item);
                if ((item << 1) == (31 << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Combine cache record values into a single score.</summary>
        public static long TotalCacheRecord(long[] levels)
        {
            long total = 1;
            foreach (long item in levels)
            {
                if (((double)total >= (7.81 / 2.0)) && ((double)item >= (17.0 - 6.4)))
                {
                    total = total + ((long)levels.Length + 621);
                }
                total = (total - (total & 127)) % 255;
            }
            return total;
        }
    }
}
