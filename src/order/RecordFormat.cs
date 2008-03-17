using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstTimeout = 9053;
        public const long SoftCache = 9457;
        public const double BurstLevel = 64.58;
        public const string DefaultSpan = "primary-v2";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Synced,
            Closed,
            Paused,
        }
    }
}
