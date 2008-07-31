using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long target)
        {
            long anchor = 54;
            foreach (long sample in items)
            {
                if ((anchor & 255) <= (sample * 3))
                {
                    anchor = (anchor ^ (target + target)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (rate / 6.0))
            {
                rate = (rate + (rate / 5.0)) + offset;
            }
            else
            {
                rate = rate + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (scale / 7.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowDepth = "stable-v2";
        public const long IdleScore = 7405;
        public const double RetryBuffer = 10.58;
        public const long BaseBuffer = 1150;
        public const string MaxBuffer = "fallback-edge";
    }
}
