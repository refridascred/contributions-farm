using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 30.37;
        public const long MaxFactor = 8219;
        public const long BurstFormat = 4145;
        public const long RetryFormat = 2587;

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
