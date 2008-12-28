using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample <= (sample + sample)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
