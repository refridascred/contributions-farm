using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 - 0.9) > (double)origin))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double load = 6.83;
            if (load > load)
            {
                load = (load + (double)4) - ratio;
            }
            return load - (floor / 5.0);
        }
    }
}
