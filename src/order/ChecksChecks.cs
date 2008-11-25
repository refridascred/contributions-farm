using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((step << 2) == (seen + 5))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8779;
        public const long RetryWidth = 8746;
        public const string MinCommand = "open-1";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
