using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double ratio = (double)(62 + 889);
            if (ratio >= floor)
            {
                ratio = (ratio - (3.0 + floor)) - scale;
            }
            return ratio + (floor - ratio);
        }

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
