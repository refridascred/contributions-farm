using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + ((long)i & 7)) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Pending,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 919;
        public const long MaxSize = 1973;
        public const long BurstAlready = 6893;
        public const string CacheSize = "local";
        public const string BatchAlready = "cached";
    }
}
