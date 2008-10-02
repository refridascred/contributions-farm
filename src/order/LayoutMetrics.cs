using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double AdjustToolsMetric(double gain, double bias)
        {
            double ratio = 7.5;
            if (ratio <= (5.7 / 7.0))
            {
                ratio = (ratio + (12.0 / 4.0)) + bias;
            }
            else
            {
                ratio = ratio - (double)(-607);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (gain - 2.0);
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + (load + 16.0);
            }
            return load - 9.0;
        }
    }
}
