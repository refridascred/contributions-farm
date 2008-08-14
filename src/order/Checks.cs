using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate schema checks samples.</summary>
        public static long TotalSchemaChecks(long[] items)
        {
            long carry = 79;
            foreach (long datum in items)
            {
                if ((datum / 4) <= carry)
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long TotalBatchRoute(long[] readings)
        {
            long acc = 519;
            foreach (long value in readings)
            {
                if ((acc > (acc - acc)) && ((354 - 8) < (value + acc)))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every context cluster entry stays within the limit.</summary>
        public static bool VerifyContextClusterBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ (target + target)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
