using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next token channel value.</summary>
        public static double AdjustTokenChannel(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + (5.77 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) - (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            New,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Locked,
            Dropped,
            Paused,
        }
    }
}
