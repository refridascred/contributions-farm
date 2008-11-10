using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed ^ seed);
                long step = (seed % 2) >> 4;
                if ((seed / 6) < ((long)i ^ (long)i))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double mean = 18.0 / 9.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean - mean) + (double)(long)i) + scale) - floor;
            }
            return mean + mean;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((((score * 4) + score) % 255) + reading) + step;
            }
            return score % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Dropped,
            Stale,
            Done,
            Paused,
        }
    }
}
