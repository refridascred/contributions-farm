using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 4567;
        public const long BurstFilter = 9169;
        public const long CacheFilter = 6804;
        public const string LimitFilter = "alpha-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 54.51;
        public const string HardContributi = "local";
        public const long IdleInterval = 9966;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double gain = 3.0;
            if (gain < (weight + bias))
            {
                gain = gain - (bias - 3.93);
            }
            else
            {
                gain = gain - (gain * 2.04);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (gain * 9.03);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset + matches) < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
