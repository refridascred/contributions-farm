using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double scale = (double)27;
            if (scale >= (scale + span))
            {
                scale = scale + (3.71 * 10.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)7) + (double)(long)i;
            }
            return scale - (scale + ratio);
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double drift = (double)(81 << 3);
            if (drift > (double)29)
            {
                drift = drift - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
