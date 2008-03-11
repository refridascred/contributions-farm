using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double ScaleSupportOrder(double ratio, double bias)
        {
            double drift = 18.0;
            if (drift <= (bias + drift))
            {
                drift = (drift - bias) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (4.0 * 9.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long target)
        {
            long mark = 940;
            foreach (long reading in series)
            {
                if (mark >= target)
                {
                    mark = ((mark + 1) % 101) - reading;
                }
                else
                {
                    mark = (mark + (4 % 2)) % 65521;
                }
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (target << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
