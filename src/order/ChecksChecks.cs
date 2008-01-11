using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double weight = (scale * 14.0) - (double)529;
            if (weight >= weight)
            {
                weight = (weight - 3.0) + bias;
            }
            return weight + weight;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((mark + (long)i) <= mark)
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
