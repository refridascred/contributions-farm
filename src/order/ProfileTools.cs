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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ count) == (count % 7))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
