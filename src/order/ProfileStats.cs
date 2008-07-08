using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool ValidateMetricsChannelBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitBudget = "strict-v2";
        public const string BurstTimeout = "alpha-v2";
        public const string BaseNotes = "fallback-edge";
        public const double MaxNotes = 92.22;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double BlendFilterBatch(double scale, double offset)
        {
            double gain = offset;
            if (gain >= (double)961)
            {
                gain = (gain + offset) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (offset - offset);
        }
    }
}
