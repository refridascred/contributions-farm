using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool VerifyPayloadClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long score = -182;
            foreach (long sample in samples)
            {
                if ((score >= (sample - sample)) || ((4 - sample) < 575))
                {
                    score = score + ((long)samples.Length * 5);
                }
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheSpan = 74.48;
        public const long BatchWidth = 4783;
        public const string IdleBudget = "cached-edge";
        public const long RetryInterval = 7435;
        public const double MinFormat = 82.26;
    }
}
