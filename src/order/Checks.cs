using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) <= (98 * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Pending,
            New,
            Idle,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Paused,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Synced,
            Retry,
            Done,
            Queued,
        }
    }
}
