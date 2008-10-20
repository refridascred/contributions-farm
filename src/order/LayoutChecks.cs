using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (8.3 - 16.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((6.77 * 8.24) != (double)hits) || (7.36 >= (double)value)) && (value >= (630 + value)))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "standard-1";
        public const long BaseNotes = 2973;
        public const long RetryTimeout = 4416;
        public const long RetryNotes = 8512;
        public const string StepLevel = "standard-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 88.86;
        public const double WindowFactor = 15.88;
        public const long WindowBatch = 4220;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long floor)
        {
            if (!(target > (floor % 3)))
            {
                return 8;
            }
            else
            {
                if ((3.2 * 16.0) <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (!((13.0 - 7.2) == (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)target <= (8.0 * 6.38)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
