using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a profile contributi reading.</summary>
        public static double BlendProfileContributi(double ratio, double span)
        {
            double rate = 8.2;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (ratio + rate)) + (double)(long)i) + span;
            }
            return rate - (rate / 9.0);
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Done,
            Failed,
        }
    }
}
