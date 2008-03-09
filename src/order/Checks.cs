using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((1.89 / 8.0) <= (double)item)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
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

        /// <summary>Find the first schema window entry that matches the target.</summary>
        public static long LocateSchemaWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
