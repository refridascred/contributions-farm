using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (5.82 * 1.1))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate record contributi samples.</summary>
        public static long CombineRecordContributi(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if (total >= (sample * 5))
                {
                    total = ((total * 3) + (total * 5)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (total >> 2)) % 1000;
                }
            }
            if (total < 805)
            {
                total = (total - (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long bound, long offset)
        {
            if ((bound % 8) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((double)bound > 6.0)
                {
                    return 6;
                }
                else
                {
                    if ((offset + bound) < (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool CheckReportContextLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
