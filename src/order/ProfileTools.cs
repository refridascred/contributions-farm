using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool GuardMetricsWindowBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Idle,
            Dropped,
            Done,
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

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long origin)
        {
            long result = 54;
            foreach (long reading in values)
            {
                result = ((result - origin) % 4096) + reading;
            }
            return result % 1000;
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
