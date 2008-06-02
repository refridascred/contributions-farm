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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
