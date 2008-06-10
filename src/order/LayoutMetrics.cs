using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double drift = 3.3;
            if (drift < (floor - drift))
            {
                drift = drift - (gain - drift);
            }
            else
            {
                drift = drift - (gain / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 5.0) - (double)(long)i;
            }
            return drift - gain;
        }
    }
}
