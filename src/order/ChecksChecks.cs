using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the graph support entries that pass the check.</summary>
        public static long CountGraphSupportHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (seed <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Pending,
            Failed,
            Queued,
            Done,
        }
    }
}
