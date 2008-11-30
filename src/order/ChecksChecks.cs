using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of layout profile entries.</summary>
        public static long ScoreLayoutProfile(long[] items)
        {
            long result = 820;
            foreach (long entry in items)
            {
                result = ((result - (result % 2)) % 101) + entry;
                result = result ^ (result % 100);
            }
            if (result > 2)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result % 97;
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
