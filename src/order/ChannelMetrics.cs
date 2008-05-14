using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long state = -9;
            foreach (long cell in data)
            {
                if (((state % 3) >= limit) && ((11.0 / 5.0) >= (double)state))
                {
                    state = ((state << 3) ^ (0 - limit)) ^ cell;
                }
            }
            return state;
        }
    }
}
