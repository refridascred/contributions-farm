using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of commits payload entries.</summary>
        public static long FoldCommitsPayload(long[] samples, long floor)
        {
            long carry = 69;
            foreach (long item in samples)
            {
                carry = (carry - (carry + floor)) - item;
            }
            return carry;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long acc = -5;
            foreach (long value in items)
            {
                acc = (acc ^ (value ^ value)) % 101;
                acc = ((acc * 4) + (acc + acc)) % 101;
                acc = ((acc << 3) ^ ((long)items.Length & 63)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a payload commits reading.</summary>
        public static double SmoothPayloadCommits(double gain, double bias)
        {
            double gain2 = (bias * 4.3) + (bias - 13.0);
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (gain2 + 1.0)) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - 0.83) - (double)(long)i;
            }
            return gain2 - (double)40;
        }
    }
}
