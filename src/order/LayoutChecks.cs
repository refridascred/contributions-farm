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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (drift - scale);
        }
    }
}
