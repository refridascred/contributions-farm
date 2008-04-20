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
