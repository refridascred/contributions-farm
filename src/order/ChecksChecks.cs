using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long CountReportFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches % 100) < matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Paused,
            Failed,
            New,
        }
    }
}
