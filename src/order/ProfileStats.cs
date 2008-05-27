using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route farm values into a single score.</summary>
        public static long DigestRouteFarm(long[] data, long floor)
        {
            long total = 53;
            foreach (long sample in data)
            {
                total = (((total << 3) ^ total) + sample) + floor;
            }
            return total;
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
