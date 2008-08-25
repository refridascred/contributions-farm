using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long total = 97;
            foreach (long reading in levels)
            {
                if (reading <= total)
                {
                    total = total ^ ((long)levels.Length >> 4);
                }
                else
                {
                    total = (total ^ (reading + reading)) % 101;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total % 16)) % 1000;
            }
            return total;
        }
    }
}
