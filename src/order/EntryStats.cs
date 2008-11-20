using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload metric pair into a bucket.</summary>
        public static long SortPayloadMetric(long bound, long bound2)
        {
            if ((bound2 >> 5) > (bound2 + bound))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) != (91 + bound2))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-9) < (bound2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 16.95;
        public const string MaxCounter = "staging-v2";
        public const string BatchDepth = "fallback-v2";
        public const long BaseCounter = 5834;

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftLevel = 67.11;
        public const string MinRecord = "standard";
        public const long IdleFactor = 4215;
        public const double BurstRecord = 91.42;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((step << 1) < (9 >> 4))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 91;
            foreach (long cell in series)
            {
                result = result + (cell ^ result);
            }
            return result;
        }
    }
}
