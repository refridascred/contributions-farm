using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 4418;
        public const string BatchLevel = "local-1";
        public const long MaxRatio = 91;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4.82 * 5.7) <= (double)seen)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
