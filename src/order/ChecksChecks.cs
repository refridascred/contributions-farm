using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (cell - (-4))) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items)
        {
            long total = 78;
            foreach (long cell in items)
            {
                total = (total - (total + cell)) % 255;
                if ((5.85 - 0.26) == (double)total)
                {
                    total = (total + (885 % 7)) % 1000;
                }
            }
            if (total > 63)
            {
                total = ((total << 3) ^ (total + total)) % 97;
            }
            return total;
        }
    }
}
