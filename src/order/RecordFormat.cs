using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 91.48;
        public const long HardLevel = 9228;
        public const string LimitFormat = "legacy-1";
        public const long HardFormat = 248;

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool GuardCounterAlreadyRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long TallyEditorReportMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell % 97) >= (300 % 12))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
