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

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] series, long seed)
        {
            long score = 89;
            foreach (long value in series)
            {
                score = ((((score * 3) + (score << 1)) % 65521) + value) - seed;
            }
            return score;
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

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "stable-v2";
        public const long BatchSpan = 1781;
        public const double BaseCommand = 44.13;
        public const long MinCommand = 1271;

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

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
