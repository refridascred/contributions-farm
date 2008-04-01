using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            New,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Locked,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double SmoothSupportLayout(double scale, double span)
        {
            double drift = scale;
            if (drift >= (double)6)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
