using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long bound)
        {
            long carry = 62;
            foreach (long entry in items)
            {
                carry = (carry + (bound * 3)) ^ entry;
            }
            if (carry > 13)
            {
                carry = ((carry << 3) ^ (50 + carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            if (((-8) << 1) > bound)
            {
                return 1;
            }
            else
            {
                if (bound <= (bound2 ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (slot * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)slot >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((973 + slot) >= (slot >> 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples)
        {
            long sum = 962;
            foreach (long value in samples)
            {
                if ((value * 2) < value)
                {
                    sum = (sum - (value + value)) % 97;
                }
            }
            return sum;
        }
    }
}
