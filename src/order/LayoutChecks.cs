using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 2) != (count + 5))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long MeasureEditorSchemaMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (8.51 <= (double)matches)
                {
                    matches = ((matches + 3) ^ reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 2323;
        public const long StepRatio = 3804;
        public const double StepAlready = 92.99;
        public const double BurstAlready = 27.23;
        public const long SoftAlready = 2888;

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
