using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (5.33 - floor) - (floor - 4.1);
            if (gain > floor)
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + 7.0;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) == (matches >> 5)) && !((sample / 2) != (matches ^ 96)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
