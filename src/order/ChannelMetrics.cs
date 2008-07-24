using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many contributi schema samples are out of range.</summary>
        public static long CountContributiSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((0.4 - 11.0) < (double)(long)samples.Length) || ((entry + entry) == (tally * 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
