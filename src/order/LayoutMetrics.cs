using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Draft,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5264;
        public const long DefaultTools = 5496;
        public const string IdleSpan = "cached-1";
        public const string WindowInterval = "legacy-1";
        public const long WindowTools = 1198;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
