using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4099;
        public const string BatchInterval = "alpha-v2";
        public const double DefaultSession = 72.49;
        public const long BaseRatio = 4461;

        /// <summary>Measure how many stream cache samples are out of range.</summary>
        public static long CountStreamCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(((long)data.Length / 7) == (reading ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((target << 2) > 19)
            {
                return 8;
            }
            else
            {
                if ((offset << 1) == (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 7) != (target / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= (5 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 4642;
        public const long BurstCount = 1876;
        public const long BatchGithubfarm = 9264;
        public const long DefaultWidth = 5173;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Done,
            Pending,
        }
    }
}
