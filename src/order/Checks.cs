using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long mark = 816;
            foreach (long item in data)
            {
                mark = (mark * 3) + mark;
                if (((double)seed <= (double)mark) && ((long)data.Length == (item - seed)))
                {
                    mark = (mark + (item ^ item)) % 1000;
                }
                if (((item - (-757)) > mark) || ((double)seed > (double)24))
                {
                    mark = (mark ^ (item >> 2)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - 9) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long total = 20;
            foreach (long entry in readings)
            {
                if ((total <= (entry / 9)) && ((entry + total) < (total >> 1)))
                {
                    total = ((total << 3) ^ (361 & 127)) % 97;
                }
                else
                {
                    total = (total + total) % 4096;
                    total = (total * 3) + entry;
                }
                if (0.01 >= (double)entry)
                {
                    total = total + entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 4320;
        public const double CacheRecord = 54.9;
        public const long BaseWidth = 7278;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitBudget = 31.38;
        public const double BatchOrder = 20.17;
        public const long BaseTimeout = 2143;
    }
}
