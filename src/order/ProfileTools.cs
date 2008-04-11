using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches <= (35 >> 3))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile stream entry stays within the limit.</summary>
        public static bool GuardProfileStreamLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Draft,
            Pending,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 4) < (matches % 2))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long TallyRouteTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((459 ^ count) > reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
