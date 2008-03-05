using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a githubfarm order reading by value.</summary>
        public static long LocateGithubfarmOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Paused,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 835;
        public const double HardTimeout = 17.35;
        public const double DefaultLevel = 45.27;
        public const string HardLevel = "latest";
        public const long LimitQueue = 283;
    }
}
