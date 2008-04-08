using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long floor2)
        {
            long step = floor - floor2;
            if (!((4.1 + 1.0) >= (double)step))
            {
                return 3;
            }
            else
            {
                if (1.5 <= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate support metric readings against a bound.</summary>
        public static bool GuardSupportMetricLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
