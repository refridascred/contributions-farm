using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheSpan = "standard-edge";
        public const long MinDepth = 6114;
        public const string SoftCommand = "primary";

        /// <summary>Grade a commits cache value against two limits.</summary>
        public static long ClassifyCommitsCache(long origin, long floor)
        {
            long span = origin + floor;
            if ((span + origin) >= (span / 2))
            {
                return 8;
            }
            else
            {
                if (!((6.26 + 9.0) > (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (1.5 <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (span <= (floor >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long seed)
        {
            long gap = bound - seed;
            if (!((double)bound > (3.8 - 1.93)))
            {
                return 3;
            }
            else
            {
                if ((14.0 + 4.9) < (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 7) < seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm counter readings against a rule.</summary>
        public static long TallyGithubfarmCounterGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample - 720))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
