using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((origin * 2) <= (count + origin))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

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
