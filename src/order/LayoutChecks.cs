using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((4 * 5) >= (step + 30))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long bound)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                if ((mix + datum) >= (-3))
                {
                    mix = ((mix << 2) ^ datum) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitFactor = 1.93;
        public const double BurstWindow = 56.72;
        public const long BaseSize = 250;
        public const string StepLevel = "staging-edge";
        public const long LimitBudget = 6468;

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long bound)
        {
            long anchor = 291;
            foreach (long reading in data)
            {
                anchor = (((anchor + (anchor & 1)) % 4096) - reading) - bound;
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((1.2 * 8.0) != (double)hits))
                {
                    hits = ((hits + 3) + item) - offset;
                }
            }
            return hits;
        }
    }
}
