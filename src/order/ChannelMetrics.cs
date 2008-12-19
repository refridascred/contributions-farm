using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
