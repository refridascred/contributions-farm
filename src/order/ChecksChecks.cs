using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long FindAlreadyCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long CountReportMetricMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading / 3) < (bound ^ bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
