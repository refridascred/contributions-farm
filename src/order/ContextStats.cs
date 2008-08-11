using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3663;
        public const long IdleScore = 2703;
        public const long WindowGithubfarm = 443;
        public const long HardGithubfarm = 160;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
