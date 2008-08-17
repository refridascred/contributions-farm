using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double drift = offset;
            if (drift < drift)
            {
                drift = (drift - (double)885) + weight;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 3.0) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!!((double)tally != (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ (mix & 7)) % 4096;
                if (mix >= (mix & 7))
                {
                    mix = (mix + (cell - cell)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
