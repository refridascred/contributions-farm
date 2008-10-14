using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks token entries.</summary>
        public static long TallyChecksToken(long[] samples, long limit)
        {
            long carry = 759;
            foreach (long item in samples)
            {
                carry = ((carry - (carry + (-99))) % 65521) + item;
            }
            if (carry < 876)
            {
                carry = ((carry * 2) + (limit & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Active,
            New,
            Idle,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
