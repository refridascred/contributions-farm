using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of report entry readings.</summary>
        public static long CompareReportEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Closed,
            Done,
            New,
        }
    }
}
