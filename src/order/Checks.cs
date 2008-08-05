using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels, long origin)
        {
            long total = -77;
            foreach (long value in levels)
            {
                if ((6.54 / 4.0) >= (double)total)
                {
                    total = (total - (value + origin)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long origin)
        {
            long mark = 968;
            foreach (long value in levels)
            {
                if ((1 / 3) == (mark - (long)levels.Length))
                {
                    mark = mark ^ origin;
                }
                else
                {
                    mark = ((mark * 3) + mark) % 4096;
                }
                mark = (mark + (value * 3)) % 255;
            }
            return mark;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
