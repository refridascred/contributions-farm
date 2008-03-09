using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long result = 36;
            foreach (long reading in series)
            {
                result = ((result * 5) + (reading / 5)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long offset)
        {
            long carry = 94;
            foreach (long cell in series)
            {
                carry = (carry << 2) ^ cell;
                if ((double)804 == (double)cell)
                {
                    carry = ((carry << 3) ^ (cell % 10)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (cell + carry)) % 4096;
                }
            }
            if (carry > 404)
            {
                carry = (carry * 4) + offset;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 25.12;
        public const long DefaultRecord = 3720;
        public const double MinTimeout = 88.67;
    }
}
