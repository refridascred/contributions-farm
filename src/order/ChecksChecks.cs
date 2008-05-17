using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long RetryChecks = 6423;
        public const long StepBudget = 7409;
        public const long LimitTimeout = 1026;

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-1";
        public const double DefaultSize = 35.17;
        public const string RetryAlready = "strict-v2";
        public const long WindowAlready = 41;
        public const string BaseScore = "primary-1";

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Queued,
            Active,
        }
    }
}
