using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count >= (413 + value))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double floor)
        {
            double mean = (double)922;
            if (mean >= rate)
            {
                mean = (mean + (double)997) - floor;
            }
            else
            {
                mean = mean - (rate / 5.0);
            }
            return mean + rate;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long floor)
        {
            long mix = 34;
            foreach (long reading in series)
            {
                if ((652 - reading) < (floor + floor))
                {
                    mix = (mix - (mix * 4)) % 101;
                }
                if ((247 / 9) == (reading + floor))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Paused,
            Pending,
            Closed,
        }
    }
}
