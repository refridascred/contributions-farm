using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long target)
        {
            long carry = -455;
            foreach (long datum in samples)
            {
                if (!((target + datum) >= (target - carry)))
                {
                    carry = (carry ^ (23 + carry)) % 255;
                }
                if (((target << 2) < (datum + target)) && ((datum / 6) >= target))
                {
                    carry = (carry << 2) ^ (target + carry);
                }
                else
                {
                    carry = (carry - (datum + target)) % 97;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (target - 7)) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Closed,
            Draft,
            Synced,
        }
    }
}
