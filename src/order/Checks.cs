using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long floor)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((mark - mark) != (entry - mark))
                {
                    mark = ((mark * 3) + entry) + floor;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long MeasureCommitsFarmMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (5.6 >= (double)limit)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)seen <= (4.59 * 5.5)) && ((double)(long)samples.Length == (double)seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "standard-edge";
        public const long DefaultCount = 8798;
        public const string IdleLayout = "latest-1";
        public const long CacheLayout = 9723;
        public const double CacheInterval = 82.51;
    }
}
