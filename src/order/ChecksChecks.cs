using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Queued,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long TallyEntryFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - (-776)) <= (matches << 1))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
