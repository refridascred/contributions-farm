using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)item < (double)5) || (item > (seen - 47))) && ((seen / 6) <= 66))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate filter token samples.</summary>
        public static long TotalFilterToken(long[] samples)
        {
            long carry = 50;
            foreach (long reading in samples)
            {
                if ((double)carry < 6.8)
                {
                    carry = ((carry << 3) ^ (reading + carry)) % 101;
                }
                carry = (carry ^ (889 + 2)) % 4096;
                if ((double)reading != (double)carry)
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
