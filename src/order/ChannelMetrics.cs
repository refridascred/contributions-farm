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

        /// <summary>Fold a list of account editor readings.</summary>
        public static long TallyAccountEditor(long[] values)
        {
            long sum = 96;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum << 2) ^ ((long)i >> 3)) % 4096;
                    sum = ((sum << 2) ^ ((-5) / 8)) % 4096;
                }
                sum = (sum + (sample >> 3)) % 1000;
            }
            return sum;
        }
    }
}
