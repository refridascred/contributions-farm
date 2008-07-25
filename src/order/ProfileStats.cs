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

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
