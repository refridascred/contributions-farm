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

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double ratio2 = 8.4;
            if (ratio2 < (double)972)
            {
                ratio2 = (ratio2 - (bias / 7.0)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - 11.0;
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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
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
