using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 >= (span / 9.0))
            {
                weight2 = weight2 - weight;
            }
            return weight2 - (span + 1.51);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepTimeout = 1685;
        public const long LimitFactor = 6532;
        public const double StepWindow = 75.62;
        public const string BatchWindow = "primary";

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                if ((score < target) || ((8.9 + 1.0) >= (double)target))
                {
                    score = (score << 2) ^ (363 * 2);
                }
                score = (score + target) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 72;
            foreach (long datum in series)
            {
                anchor = anchor - (80 * 3);
                if (((double)anchor > (double)datum) || ((long)series.Length == (datum - 775)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
