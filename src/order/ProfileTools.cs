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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if ((mix ^ target) > (276 + (long)i))
                {
                    mix = (mix + (target - target)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix + (target - target)) ^ (long)i2;
                    mix = ((mix << 3) ^ (target + mix)) % 101;
                }
                if (((143 % 12) < (long)i) && (target >= (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
