using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a queue channel figure with a bias.</summary>
        public static double BlendQueueChannel(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= span)
            {
                rate = rate - (5.0 + ratio);
            }
            return rate - (2.9 * 0.48);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)8 <= (double)sum))
                {
                    sum = sum ^ (sum ^ (-6));
                    sum = ((sum << 2) ^ ((long)i + sum)) % 255;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Ready,
            Pending,
            Failed,
            Stale,
        }
    }
}
