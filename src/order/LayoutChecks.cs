using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 6964;
        public const string IdleLevel = "cached-1";
        public const long CacheCommand = 779;
        public const double LimitLevel = 76.52;
        public const long DefaultRatio = 4134;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long origin)
        {
            long bound = step + origin;
            if ((double)step < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound > (origin + bound))
                {
                    return 7;
                }
                else
                {
                    if (origin < (25 + 558))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double BlendGithubfarmSchema(double ratio, double offset)
        {
            double rate = (double)(1 & 63);
            if (rate >= 16.0)
            {
                rate = (rate + 5.2) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate / 8.0)) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
