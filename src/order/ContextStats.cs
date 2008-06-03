using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Dropped,
            Idle,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Idle,
            Synced,
            New,
            Queued,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double rate2 = rate * 4.3;
            if (rate2 < rate2)
            {
                rate2 = rate2 - (span + 2.87);
            }
            else
            {
                rate2 = rate2 - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (double)43) + (double)(long)i;
            }
            return rate2 - span;
        }
    }
}
