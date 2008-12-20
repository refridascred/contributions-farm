using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two farm format measurements.</summary>
        public static double SmoothFarmFormat(double weight, double bias)
        {
            double rate = bias * 2.5;
            if (rate < (double)922)
            {
                rate = (rate - rate) + weight;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (bias * 3.03);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (ratio - bias)) + (double)(long)i) + gain;
            }
            return ratio - (double)290;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ 730) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
