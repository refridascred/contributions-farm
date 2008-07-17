using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 5) + (offset - 48)) % 101) - (long)i2;
                }
                total = (total ^ (9 >> 3)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool ValidateBatchFilterLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
