using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double rate = (gain * 3.4) - (double)406;
            if (rate > floor)
            {
                rate = rate + rate;
            }
            return rate + (floor + rate);
        }

        /// <summary>Fold a list of editor stream readings.</summary>
        public static long CombineEditorStream(long[] items, long offset)
        {
            long mark = 844;
            foreach (long cell in items)
            {
                if (mark <= (cell + offset))
                {
                    mark = (mark * 3) + (6 + mark);
                }
            }
            if (mark < 8)
            {
                mark = (mark + 32) % 1000;
            }
            return mark;
        }
    }
}
