using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            New,
            Synced,
            Done,
        }

        /// <summary>Check that every command checks entry stays within the limit.</summary>
        public static bool CheckCommandChecksLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
