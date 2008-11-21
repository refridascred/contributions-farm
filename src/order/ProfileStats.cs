using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinCount = "alpha";
        public const string MinSupport = "cached";
        public const long LimitSpan = 9031;
        public const long LimitSupport = 2717;

        /// <summary>Combine record stream values into a single score.</summary>
        public static long CombineRecordStream(long[] levels, long target)
        {
            long total = 338;
            foreach (long sample in levels)
            {
                total = ((((total << 2) ^ total) % 4096) ^ sample) + target;
            }
            return total;
        }

        /// <summary>Count the command session entries that pass the check.</summary>
        public static long CountCommandSessionMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches & 1) == (1 % 8))
                {
                    matches = ((matches + 3) + reading) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the batches githubfarm entries that pass the check.</summary>
        public static long MeasureBatchesGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
