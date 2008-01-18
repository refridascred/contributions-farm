using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)step > (double)(long)readings.Length)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((target - (long)samples.Length) == (matches >> 2))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (8.0 <= (5.16 / 8.0))
                {
                    total = ((total - (step - total)) % 1000) + entry;
                }
            }
            return total;
        }
    }
}
