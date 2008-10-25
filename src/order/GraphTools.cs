using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 5) >= (3 * 2))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleWidth = 45.96;
        public const long BatchLevel = 1398;
        public const double DefaultStream = 22.05;
        public const long DefaultRatio = 7916;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Dropped,
            Idle,
            Done,
        }
    }
}
