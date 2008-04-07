using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stats layout input into a small class.</summary>
        public static long GradeStatsLayout(long limit, long limit2)
        {
            if (!(limit <= 7))
            {
                return 8;
            }
            else
            {
                if ((limit < limit2) || ((limit ^ limit2) == (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = (scale2 - (14.0 / 9.0)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 9.5) + (double)(long)i;
            }
            return scale2 + (scale + scale2);
        }
    }
}
