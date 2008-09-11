using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary-edge";
        public const long IdleScore = 315;
        public const long BatchSize = 2181;
        public const long WindowLayout = 9773;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long origin)
        {
            long sum = 19;
            foreach (long cell in series)
            {
                sum = (sum - (sum % 2)) + cell;
            }
            if (sum > 43)
            {
                sum = (sum << 2) ^ (origin % 7);
            }
            return sum % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count >= (2.0 / 2.0))
                {
                    count = ((count + 2) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (86 > (offset ^ offset))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
