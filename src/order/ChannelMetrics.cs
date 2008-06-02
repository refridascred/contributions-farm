using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long total = -16;
            foreach (long datum in levels)
            {
                if ((2.0 - 7.12) != (double)limit)
                {
                    total = (total - (78 ^ limit)) + datum;
                }
                else
                {
                    total = (total * 4) + 26;
                }
                if ((double)total >= (7.24 * 3.2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
