using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long result = 289;
            foreach (long entry in samples)
            {
                if ((seed * 3) > (96 + result))
                {
                    result = ((result * 2) + 90) ^ entry;
                }
            }
            if (result < 460)
            {
                result = (result - (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)limit >= (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool CheckFarmBatchBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
