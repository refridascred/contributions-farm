using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + mix) % 65521;
                if (((double)mix > (9.3 / 3.0)) && ((double)mix < (double)floor))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4513;
        public const string BurstRatio = "legacy";
        public const long BatchSpan = 3682;
        public const long StepDepth = 6618;
        public const double RetryTimeout = 67.56;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Retry,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
