using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items)
        {
            long total = 448;
            foreach (long value in items)
            {
                if ((14.0 * 1.5) >= (double)value)
                {
                    total = total - (total ^ (long)items.Length);
                }
                if ((total / 4) <= (580 & 3))
                {
                    total = (total ^ (value - value)) % 1000;
                }
                if ((65 > (446 ^ value)) || ((value - 0) < total))
                {
                    total = total + (total ^ total);
                }
                else
                {
                    total = total + (total % 64);
                }
            }
            if (total < 14)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard";
        public const long HardBudget = 1126;
        public const long SoftRatio = 4534;

        /// <summary>Check that every commits cluster entry stays within the limit.</summary>
        public static bool ValidateCommitsClusterBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
