using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + value) <= (value - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Paused,
            Active,
            Idle,
            Draft,
        }
    }
}
