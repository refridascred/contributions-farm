using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed <= (seed + seed)) && (((long)i + (long)i) <= (seed & 3))))
                {
                    state = (state + ((long)i / 2)) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a farm account figure with a bias.</summary>
        public static double AdjustFarmAccount(double rate, double floor)
        {
            double gain = (rate - floor) + rate;
            if (gain <= 0.7)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 9.0;
        }
    }
}
