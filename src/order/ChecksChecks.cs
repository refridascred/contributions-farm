using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long TotalBatchesCounter(long[] samples)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                carry = (carry + (65 >> 2)) % 97;
                if (!(((double)carry < 1.39) && ((double)value >= (18.0 + 20.0))))
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)value < (15.0 + 11.0))
                {
                    carry = (carry * 4) + (6 - value);
                }
            }
            return carry;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long LocateStreamFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
