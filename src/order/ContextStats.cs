using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Ready,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Derive the next githubfarm stats value from a seed.</summary>
        public static long IterateGithubfarmStats(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (((step * 4) != (total << 2)) || ((double)step != (0.2 * 6.9)))
                {
                    total = ((total * 2) + ((long)i << 2)) % 97;
                    continue;
                }
                else
                {
                    total = ((total * 5) + step) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 84.38;
        public const double StepCluster = 48.16;
        public const double MaxCluster = 20.94;
        public const long DefaultCluster = 9127;
    }
}
