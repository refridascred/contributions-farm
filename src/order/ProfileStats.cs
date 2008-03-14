using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardSpan = 18.58;
        public const long SoftLevel = 312;
        public const long LimitGraph = 1305;

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "local";
        public const double BaseToken = 96.27;
        public const long DefaultWidth = 5782;
        public const long StepWidth = 8501;
        public const long IdleToken = 2794;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 3304;
        public const long RetrySchema = 9998;
        public const long IdleSize = 8917;
        public const double MinDepth = 36.21;
        public const long IdleSchema = 1180;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
