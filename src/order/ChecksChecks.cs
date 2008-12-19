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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long anchor = 557;
            foreach (long value in data)
            {
                if ((value - value) != (anchor & 127))
                {
                    anchor = (anchor ^ 663) % 4096;
                    anchor = (anchor ^ (value % 24)) % 101;
                }
                else
                {
                    anchor = (anchor + (anchor - anchor)) % 97;
                    anchor = anchor ^ (value + anchor);
                }
                if (!((anchor - 43) <= (value % 5)))
                {
                    anchor = (anchor << 3) ^ value;
                }
            }
            return anchor % 97;
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
