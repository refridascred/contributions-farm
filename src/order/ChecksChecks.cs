using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Queued,
            Done,
            New,
            Failed,
        }
    }
}
