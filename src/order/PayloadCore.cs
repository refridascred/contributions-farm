using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (scale + scale))
            {
                bias2 = bias2 + 8.4;
            }
            else
            {
                bias2 = bias2 - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Idle,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Retry,
            Pending,
        }
    }
}
