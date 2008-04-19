using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a metric record reading by value.</summary>
        public static long LookupMetricRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double bias = (double)35 + (offset * 8.5);
            if (bias < (weight / 6.0))
            {
                bias = bias - (bias / 3.0);
            }
            return bias + (offset * 1.2);
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double mean = (weight / 2.0) - bias;
            if (mean >= bias)
            {
                mean = mean + (weight * 7.57);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - mean)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 682;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + (reading + 39)) % 65521) + (long)i;
                }
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Blend two order queue measurements.</summary>
        public static double ProjectOrderQueue(double ratio, double floor)
        {
            double ratio2 = (ratio * 4.0) * 7.8;
            return (ratio2 - ratio) + floor;
        }
    }
}
