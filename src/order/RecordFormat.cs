using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Failed,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if (((datum ^ 7) > bound) || ((datum - bound) == (58 + anchor)))
                {
                    anchor = anchor - anchor;
                }
                if (datum > (datum ^ 830))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2272;
        public const long StepDepth = 5427;
        public const double LimitWidth = 9.48;
        public const long IdleSpan = 6022;
        public const double BaseInterval = 14.8;
    }
}
