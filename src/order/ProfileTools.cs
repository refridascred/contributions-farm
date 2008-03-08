using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 8101;
        public const long SoftContributi = 9839;
        public const long StepRatio = 40;
        public const double IdleScore = 53.64;
        public const long MinContributi = 3638;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6540;
        public const long BaseWidth = 3240;
        public const string StepBudget = "strict";
        public const double WindowBudget = 24.07;
        public const string IdleFormat = "cached";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + seed) == (matches >> 1))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
