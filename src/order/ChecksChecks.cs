using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) <= (long)levels.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long origin)
        {
            long total = 324;
            foreach (long reading in samples)
            {
                total = ((total - (reading % 5)) % 255) + origin;
            }
            if (total > 540)
            {
                total = (total ^ total) % 101;
            }
            return total % 97;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((floor % 12) >= (long)i) || ((floor / 4) >= floor))
                {
                    carry = (carry + floor) % 255;
                }
                if ((floor + (long)i) <= (carry >> 4))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry - (6 & 1)) % 4096;
                    carry = ((carry << 3) ^ (7 << 3)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
