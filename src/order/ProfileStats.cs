using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale + (double)30;
            }
            else
            {
                scale = scale - (gain + floor);
            }
            return scale + (scale + gain);
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count >= (count - 253)) && ((0.85 - 0.5) == (double)entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
