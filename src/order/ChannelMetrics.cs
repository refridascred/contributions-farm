using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mix = -25;
            foreach (long cell in data)
            {
                mix = ((mix + (mix + mix)) % 97) + cell;
                mix = ((mix * 2) + mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 5824;
        public const string DefaultInterval = "cached";
        public const double LimitSpan = 67.5;
        public const string MinBudget = "fallback-edge";
        public const long MaxLevel = 8534;

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double gain = offset;
            if (gain < offset)
            {
                gain = gain + (offset - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (rate * 8.5)) + (double)(long)i;
            }
            return gain + (offset - gain);
        }
    }
}
