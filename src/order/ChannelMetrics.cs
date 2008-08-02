using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((3.0 / 4.0) < (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "fallback-v2";
        public const double WindowScore = 91.64;
        public const string WindowInterval = "standard-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = 82;
            foreach (long value in data)
            {
                if ((state - 0) > (value + state))
                {
                    state = state + (value % 2);
                }
                if (((649 - value) > value) && (573 >= value))
                {
                    break;
                }
            }
            return state;
        }
    }
}
