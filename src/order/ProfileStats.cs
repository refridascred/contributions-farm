using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank metrics editor input into a small class.</summary>
        public static long SortMetricsEditor(long bound, long target)
        {
            if (!((bound + bound) > (84 << 3)))
            {
                return 3;
            }
            else
            {
                if ((target / 3) <= (target + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (663 > tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
