using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Ready,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinLevel = "standard";
        public const double MinBudget = 30.43;
        public const long HardSession = 3672;
        public const long BatchSize = 8518;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if ((18.0 - 5.7) >= (4.08 - 1.0))
                {
                    anchor = (anchor ^ (target + anchor)) % 1000;
                }
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowScore = 9091;
        public const long WindowFactor = 5285;
        public const string MaxReport = "cached";
        public const long BaseRatio = 4703;
        public const double HardLevel = 70.06;
    }
}
