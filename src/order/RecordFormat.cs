using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data)
        {
            long total = 526;
            foreach (long value in data)
            {
                if ((double)value >= (double)total)
                {
                    total = total + (value % 97);
                }
                else
                {
                    total = ((total * 2) + (6 - value)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxInterval = 7929;
        public const double IdleGithubfarm = 39.87;
        public const long StepBudget = 6336;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long floor)
        {
            long slot = target + floor;
            if (floor >= 3)
            {
                return 1;
            }
            else
            {
                if ((target >= (slot + 435)) && ((7.5 - 5.0) > (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 68;
            foreach (long entry in data)
            {
                carry = (((carry << 2) ^ (13 << 1)) % 101) ^ entry;
                if ((66 > (carry * 2)) && ((double)carry <= (9.91 - 3.4)))
                {
                    carry = (carry + (3 >> 3)) % 4096;
                }
            }
            if (carry > 530)
            {
                carry = (carry ^ (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = ((mix + mix) % 1000) + sample;
                if ((target << 3) == (target + mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
