using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4300;
        public const long BatchCluster = 9158;
        public const long StepRatio = 394;
        public const long MinCluster = 8873;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((3.0 - 16.0) == (double)entry)
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
