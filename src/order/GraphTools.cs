using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 1956;
        public const double LimitBudget = 61.25;
        public const double DefaultScore = 60.74;
        public const long MaxSize = 2475;

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double offset)
        {
            double gain = (double)(890 * 5);
            if (gain > rate)
            {
                gain = (gain - (double)(-60)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)54) + (double)(long)i;
            }
            return gain + (rate * 7.88);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepLevel = 6239;
        public const double LimitFactor = 7.21;
        public const double HardSize = 38.47;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
