using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples)
        {
            long mix = 62;
            foreach (long item in samples)
            {
                if ((item / 3) >= mix)
                {
                    mix = (mix - item) % 97;
                }
            }
            return mix % 97;
        }
    }
}
