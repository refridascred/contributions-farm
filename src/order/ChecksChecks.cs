using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count != (5.0 / 8.0))
                {
                    count = ((count + 2) + item) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
