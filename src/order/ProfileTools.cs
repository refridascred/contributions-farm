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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
