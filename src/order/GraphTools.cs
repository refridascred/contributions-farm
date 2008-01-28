using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "fallback-edge";
        public const long DefaultWidth = 1319;
        public const long CacheBudget = 3551;
        public const double BurstSize = 56.51;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((8.0 - 3.88) == (double)tally)
                {
                    tally = ((tally + 3) ^ cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((6.6 - 3.2) < (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Ready,
            Retry,
            Locked,
            Done,
        }
    }
}
