using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double scale = 0.68;
            if (scale <= scale)
            {
                scale = (scale + rate) - offset;
            }
            return scale + 3.0;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long bound, long offset)
        {
            long next = bound - offset;
            if ((double)offset < (double)next)
            {
                return 0;
            }
            else
            {
                if (next >= (867 + offset))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
