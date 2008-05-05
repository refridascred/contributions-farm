using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheSpan = "cached-edge";
        public const long WindowReport = 1067;
        public const long MinReport = 8893;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxInterval = 4100;
        public const long IdleCount = 9687;
        public const long IdleStream = 3064;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Locked,
            Queued,
        }
    }
}
