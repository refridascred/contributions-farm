using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
