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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Dropped,
            Pending,
            New,
            Synced,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 71;
            foreach (long value in levels)
            {
                if (((acc & 63) <= 40) || (acc < (value ^ value)))
                {
                    acc = acc - (acc >> 1);
                }
            }
            return acc;
        }
    }
}
