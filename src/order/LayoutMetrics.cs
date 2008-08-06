using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepInterval = 6227;
        public const double HardAlready = 37.73;
        public const long CacheFactor = 2631;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 2597;
        public const long WindowReport = 6921;
        public const string BurstReport = "open";
        public const long StepReport = 123;
    }
}
