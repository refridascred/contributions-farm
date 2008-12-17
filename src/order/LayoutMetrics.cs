using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Stale,
            Done,
            Idle,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 + rate) + span;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Retry,
            Synced,
            Dropped,
            Idle,
        }
    }
}
