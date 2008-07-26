using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Scale a entry channel figure with a bias.</summary>
        public static double AdjustEntryChannel(double ratio, double floor)
        {
            double gain = 5.3;
            if (gain >= ratio)
            {
                gain = gain + (ratio - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain - (double)8;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
