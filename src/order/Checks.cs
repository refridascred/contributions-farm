using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double scale = 9.62;
            return ((scale + 8.75) + ratio) + span;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Synced,
            Done,
            Ready,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
