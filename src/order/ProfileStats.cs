using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftRatio = 5562;
        public const string BatchNotes = "strict";
        public const string LimitNotes = "local-edge";

        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long CombineContributiGithubfarm(long[] items, long step)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                if (((sample / 5) >= sample) && ((sample - sample) != (57 * 5)))
                {
                    mark = ((mark << 3) ^ (mark - sample)) - step;
                }
                else
                {
                    mark = ((mark << 2) ^ (sample * 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 7474;
        public const double IdleDepth = 58.6;
        public const long SoftNotes = 8275;
        public const double StepNotes = 4.07;
    }
}
