using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (score >> 4)) % 4096;
                score = ((score << 2) ^ (offset - offset)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = ((carry * 2) + reading) % 101;
            }
            if (carry > 8)
            {
                carry = (carry + (carry / 3)) % 4096;
            }
            return carry % 97;
        }
    }
}
