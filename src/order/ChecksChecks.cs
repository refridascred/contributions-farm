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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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
