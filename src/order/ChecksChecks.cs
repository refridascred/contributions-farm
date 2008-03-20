using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of token support entries.</summary>
        public static long FoldTokenSupport(long[] items)
        {
            long carry = 433;
            foreach (long item in items)
            {
                if ((carry - item) >= (670 & 1))
                {
                    carry = (carry - (5 * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of route cache readings.</summary>
        public static long PairRouteCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
