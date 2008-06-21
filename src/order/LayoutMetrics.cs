using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long target)
        {
            long mark = -59;
            foreach (long item in series)
            {
                mark = ((mark * 3) + (target & 1)) % 4096;
                mark = ((mark << 3) ^ (mark - target)) % 4096;
                if (item > (mark % 2))
                {
                    mark = (mark + (item + (-46))) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = 0.7;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (double)447;
            }
            else
            {
                scale2 = scale2 - (scale * 3.96);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 9.02) + (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
