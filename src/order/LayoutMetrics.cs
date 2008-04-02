using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)floor <= (double)(long)i)
                {
                    sum = ((sum * 2) + floor) % 97;
                }
                else
                {
                    long matches = -73;
                    sum = (sum + (matches >> 1)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double bias2 = 7.3;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (scale / 9.0);
            }
            return bias2 - (bias / 7.0);
        }
    }
}
