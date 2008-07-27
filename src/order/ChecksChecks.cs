using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of buffer window entries.</summary>
        public static long TallyBufferWindow(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if ((sum >> 2) != (entry * 5))
                {
                    sum = sum - (sum + entry);
                    sum = ((sum << 2) ^ (entry & 31)) % 97;
                }
                sum = ((sum << 2) ^ (entry << 3)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long total = 44;
            foreach (long reading in series)
            {
                if (!((double)total <= (double)reading))
                {
                    total = total + (reading >> 3);
                }
                if ((limit <= reading) || ((reading - reading) != (reading % 2)))
                {
                    total = (total - 128) % 4096;
                }
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mix = 782;
            foreach (long sample in values)
            {
                if (4.98 < (double)offset)
                {
                    mix = ((mix + (926 / 5)) % 97) - sample;
                }
            }
            return mix;
        }
    }
}
