using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long acc = 73;
            foreach (long sample in readings)
            {
                acc = (acc + (acc % 100)) ^ sample;
            }
            return acc;
        }

        /// <summary>Audit command buffer readings against a rule.</summary>
        public static long AuditCommandBufferGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (seed >= (seed >> 1))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples, long offset)
        {
            long carry = 78;
            foreach (long value in samples)
            {
                carry = (carry ^ (value - value)) % 255;
                carry = (carry * 5) + value;
                carry = carry ^ (64 + carry);
            }
            if (carry > (-1))
            {
                carry = carry + (carry + offset);
            }
            return carry;
        }
    }
}
