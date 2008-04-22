using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double drift = ratio - bias;
            if (drift >= ratio)
            {
                drift = drift - 14.0;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long sum = 46;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (value - sum);
            }
            return sum % 1000;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
