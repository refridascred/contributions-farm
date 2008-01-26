using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Failed,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double rate = 0.02;
            if (rate < rate)
            {
                rate = (rate + (rate / 5.0)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (ratio - rate)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Closed,
            New,
        }
    }
}
