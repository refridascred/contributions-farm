using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((bound + item) < bound) || ((20.0 + 1.1) == (double)bound)) && ((8.0 >= (double)matches) || ((432 << 2) >= item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long next = (sum + sum) + (step * 4);
                    sum = (sum - next) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a format support pair into a bucket.</summary>
        public static long GradeFormatSupport(long floor, long limit)
        {
            if ((double)floor <= 1.88)
            {
                return 2;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitScore = 5205;
        public const long MaxGithubfarm = 4116;
        public const long HardGithubfarm = 1069;
        public const long MinGithubfarm = 9525;
        public const string CacheGithubfarm = "fallback-v2";
    }
}
