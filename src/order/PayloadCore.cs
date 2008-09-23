using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Count cache account pairs that satisfy a relation.</summary>
        public static long CompareCacheAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Ready,
            Active,
            Idle,
        }
    }
}
