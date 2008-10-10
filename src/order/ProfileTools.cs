using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count * 2) < (count * 3))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count buffer format pairs that satisfy a relation.</summary>
        public static long OverlapBufferFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session metrics counter forward.</summary>
        public static long RollSessionMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + ((long)i & 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long seed)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry - 78) ^ reading) - seed;
                carry = (carry - 252) % 97;
            }
            return carry % 65521;
        }
    }
}
