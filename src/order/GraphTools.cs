using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-1";
        public const long BatchLevel = 400;
        public const long BurstEditor = 7379;
        public const long BatchEditor = 3713;
        public const long RetryWidth = 1675;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample ^ seed) > (-1)) || ((74 - 8) < (seed / 9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 255) < (matches + 82))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
