using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double weight = (ratio / 7.0) - (ratio / 9.0);
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + gain) + (double)(long)i) - rate;
            }
            return gain - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((floor + floor) == (matches / 6))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double load = (floor - 20.0) * 2.9;
            if (load < (load - load))
            {
                load = load + load;
            }
            else
            {
                load = load + (scale * 14.0);
            }
            return load + load;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheScore = 3363;
        public const long LimitContext = 3437;
        public const string StepContext = "cached";
    }
}
