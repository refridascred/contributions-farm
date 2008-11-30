using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "cached";
        public const double IdleSession = 43.97;
        public const long WindowSpan = 1362;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 1190;
        public const long SoftFactor = 4952;
        public const long IdleGithubfarm = 5223;
        public const long HardSpan = 9011;
        public const long DefaultGithubfarm = 9676;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Retry,
            Draft,
        }
    }
}
