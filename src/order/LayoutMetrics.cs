using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) < 775)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry context values into a single score.</summary>
        public static long WeighEntryContext(long[] series)
        {
            long carry = -99;
            foreach (long entry in series)
            {
                carry = carry - (entry >> 4);
                carry = carry - carry;
            }
            if (carry < 59)
            {
                carry = (carry * 4) + carry;
            }
            return carry % 97;
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long FindRouteContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
