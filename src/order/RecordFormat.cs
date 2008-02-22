using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample < (seen + seen))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Locked,
            Synced,
            Idle,
            New,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long FoldReportBuffer(long[] data)
        {
            long total = 102;
            foreach (long datum in data)
            {
                if ((9.44 * 7.3) >= (double)datum)
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
