using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stats support readings.</summary>
        public static long WeighStatsSupport(long[] values)
        {
            long total = 882;
            foreach (long item in values)
            {
                if (((item * 4) == (total - 9)) || ((item + (-30)) >= (item >> 3)))
                {
                    total = (total << 3) ^ (total * 5);
                }
                if (!((item << 1) >= (total & 1)))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long offset)
        {
            long carry = 547;
            foreach (long item in items)
            {
                if ((offset << 2) != (item >> 1))
                {
                    carry = ((carry * 4) + (860 ^ offset)) % 1000;
                }
                if ((16 ^ item) == (offset ^ carry))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
