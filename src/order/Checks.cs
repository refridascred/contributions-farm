using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "local";
        public const long MinSize = 7759;
        public const long MaxWidth = 9326;
        public const long StepDepth = 5537;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Idle,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
