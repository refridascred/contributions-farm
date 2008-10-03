using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Idle,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long seed)
        {
            if ((2 / 5) > seed)
            {
                return 0;
            }
            else
            {
                if (((-8) % 7) < seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 2) != (origin + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if (!((floor & 31) <= (230 / 7)))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((25 & 15) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double drift = offset;
            if (drift <= gain)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - offset;
            }
            return drift - (gain + offset);
        }
    }
}
