using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((offset << 3) >= 4)
            {
                return 8;
            }
            else
            {
                if ((offset2 + target) <= (offset & 31))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
