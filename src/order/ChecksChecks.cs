using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (6.4 - 12.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 60;
            foreach (long sample in items)
            {
                if ((sample + sample) >= 1)
                {
                    total = (total - (total - 338)) % 1000;
                }
                if ((sample - sample) < (670 * 5))
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }
    }
}
