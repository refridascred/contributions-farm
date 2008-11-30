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

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long anchor = 9;
            foreach (long sample in readings)
            {
                if (((seed + anchor) <= (sample + sample)) || ((double)seed > (double)anchor))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
                anchor = (anchor ^ (seed << 2)) % 4096;
                if (((sample / 5) != (sample ^ sample)) || ((seed / 6) != (49 + seed)))
                {
                    break;
                }
            }
            if (anchor > 962)
            {
                anchor = (anchor ^ (seed - seed)) % 255;
            }
            return anchor;
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
