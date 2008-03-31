using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)entry) && (entry >= (0 + 69)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((carry > (carry >> 4)) && ((0.02 + 2.3) <= (double)seed))
                {
                    carry = ((carry * 5) + ((long)i << 1)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
