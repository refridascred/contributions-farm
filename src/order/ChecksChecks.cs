using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long ScoreSupportMetric(long[] readings, long seed)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (seed >= total)
                {
                    total = (total << 2) ^ (seed * 3);
                }
                total = total ^ (total * 3);
                total = ((total * 3) + (value & 255)) % 101;
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
