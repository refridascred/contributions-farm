using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double gain = (double)((-22) / 4);
            if (gain >= 2.0)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (rate + floor);
            }
            return gain - floor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long score = 296;
            foreach (long value in items)
            {
                if (!(8.0 < (double)score))
                {
                    score = (score - (39 << 2)) - value;
                }
            }
            if (score > 792)
            {
                score = (score + floor) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
