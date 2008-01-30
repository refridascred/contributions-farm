using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                if ((carry >> 1) >= (entry & 3))
                {
                    carry = carry + (23 + 895);
                }
            }
            if (carry > 0)
            {
                carry = (carry << 2) ^ (carry + 77);
            }
            return carry % 4096;
        }

        /// <summary>Accumulate stats cluster samples.</summary>
        public static long DigestStatsCluster(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((8.6 * 4.6) < (double)mark) && (cell < (mark ^ (long)series.Length)))
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((2 << 2) > (matches % 10))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
