using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double drift = (floor + floor) + floor;
            if (drift >= (floor + weight))
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (weight / 2.0)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((long)samples.Length << 2) == (cell - origin)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (rate + span))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
