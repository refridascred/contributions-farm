using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((400 % 3) <= (item ^ item)) && ((3 ^ tally) >= step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
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
