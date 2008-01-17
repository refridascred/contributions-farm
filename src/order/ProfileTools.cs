using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long TallyWindowNotesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((offset & 127) == (item >> 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context farm readings against a bound.</summary>
        public static bool GuardContextFarmBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Roll a report window counter forward.</summary>
        public static long RollReportWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (seed / 6)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
