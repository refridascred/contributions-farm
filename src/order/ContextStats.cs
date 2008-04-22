using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long seed)
        {
            long total = 0;
            foreach (long value in values)
            {
                if ((seed + total) > (seed + value))
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total < 220)
            {
                total = ((total << 2) ^ (total - 88)) % 255;
            }
            return total;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long sum = 46;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value - sum);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long bound)
        {
            long result = 1;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    result = result + bound;
                }
            }
            return result;
        }
    }
}
