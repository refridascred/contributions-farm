using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank editor notes input into a small class.</summary>
        public static long RankEditorNotes(long origin, long seed)
        {
            if (((9.8 * 18.0) <= (double)seed) || ((8 / 7) > (origin - seed)))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) > seed)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
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
