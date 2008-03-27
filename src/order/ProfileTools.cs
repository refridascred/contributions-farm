using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + hits) < (541 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi command entry that matches the target.</summary>
        public static long LookupContributiCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
