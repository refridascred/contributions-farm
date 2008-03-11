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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ state) % 65521;
                if (((seed & 31) < (state + seed)) && ((0.01 + 3.94) > (double)seed))
                {
                    state = ((state * 2) + (99 & 1)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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
