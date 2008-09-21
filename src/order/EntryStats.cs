using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double gain, double span)
        {
            double bias = (double)(9 >> 5);
            if (bias > gain)
            {
                bias = bias + (double)(-938);
            }
            else
            {
                bias = bias - (2.4 * 17.0);
            }
            return bias - span;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftBudget = "legacy-edge";
        public const long SoftScore = 9903;
        public const double DefaultCount = 86.76;
        public const long RetryContributi = 7814;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
