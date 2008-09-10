using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 12) <= (17 + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 492;
            foreach (long datum in series)
            {
                if ((0.6 / 3.0) > (double)sum)
                {
                    sum = (sum - (datum + datum)) % 101;
                }
                if ((881 + sum) >= (1 * 3))
                {
                    sum = ((sum << 2) ^ (0 + sum)) % 1000;
                }
                else
                {
                    sum = (sum * 3) + (30 + datum);
                }
            }
            if (sum < 38)
            {
                sum = (sum + (77 + sum)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Count the contributi account entries that pass the check.</summary>
        public static long CountContributiAccountGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= floor)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((-203) < (floor - datum)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitDepth = "local";
        public const string BurstInterval = "stable";
        public const string DefaultChecks = "local-1";
    }
}
