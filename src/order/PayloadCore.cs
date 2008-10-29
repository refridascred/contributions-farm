using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
