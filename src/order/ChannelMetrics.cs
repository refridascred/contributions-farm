using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Locked,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Pending,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double bias, double bias2)
        {
            double bias3 = bias2 * 1.92;
            if (bias3 < (bias / 2.0))
            {
                bias3 = bias3 + bias3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + (bias + 0.2)) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
