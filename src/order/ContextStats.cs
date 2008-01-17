using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Active,
            New,
            Closed,
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

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double scale, double offset)
        {
            double mean = 18.0;
            if (mean > 2.68)
            {
                mean = (mean + 9.33) - offset;
            }
            else
            {
                mean = mean - scale;
            }
            return mean - (double)2;
        }
    }
}
