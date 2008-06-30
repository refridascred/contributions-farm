using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((count - count) == (397 ^ entry)) || (entry > 449)) || ((48 + entry) < (98 - (long)readings.Length)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
