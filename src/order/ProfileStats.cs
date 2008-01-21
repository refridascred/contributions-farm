using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels, long step)
        {
            long mix = 257;
            foreach (long item in levels)
            {
                mix = mix - 3;
                mix = ((mix * 5) + item) % 1000;
                mix = (mix ^ item) % 255;
            }
            if (mix < 407)
            {
                mix = mix ^ (step + mix);
            }
            return mix;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Locked,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9168;
        public const double HardInterval = 17.54;
        public const string DefaultScore = "standard-1";

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
