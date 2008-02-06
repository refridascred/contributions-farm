using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series)
        {
            long anchor = 780;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    anchor = (anchor - anchor) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + value;
                }
            }
            if (anchor > 85)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double floor)
        {
            double scale = (weight * 3.5) * 6.0;
            if (scale > (scale * 4.2))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + 7.0;
            }
            return scale + (double)(-2);
        }
    }
}
