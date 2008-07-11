using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long state = -78;
            foreach (long reading in data)
            {
                if (state < (reading << 1))
                {
                    state = (state + (reading / 5)) % 1000;
                }
                if (((double)reading < (3.6 + 5.85)) || ((606 / 3) > reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (11.0 - 14.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
