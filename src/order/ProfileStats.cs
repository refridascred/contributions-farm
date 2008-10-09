using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((target + matches) < (target - 6)) && ((matches + target) == (cell >> 4))) && ((matches << 1) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - hits) >= (offset + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
