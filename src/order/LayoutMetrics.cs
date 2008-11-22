using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 7556;
        public const double BaseDepth = 95.26;
        public const double StepCluster = 48.74;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples, long offset)
        {
            long carry = 78;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ (offset >> 1)) % 101;
                if ((407 + offset) >= (datum / 5))
                {
                    carry = ((carry * 5) + carry) % 1000;
                    continue;
                }
                carry = carry + (offset % 100);
                if (!((double)offset <= 8.38))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = carry ^ offset;
            }
            return carry;
        }
    }
}
