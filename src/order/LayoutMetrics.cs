using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + state) >= (517 + offset))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                if ((state - offset) > (state / 6))
                {
                    state = state - (state - state);
                }
                else
                {
                    state = (state - offset) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
