using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)(4 + 7);
            if (mean >= (span - span))
            {
                mean = (mean + (double)0) - rate;
            }
            return mean - (double)93;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long target)
        {
            if (((step - step) <= (target + target)) || ((target % 16) == (step << 3)))
            {
                return 8;
            }
            else
            {
                if (((step ^ target) < (target + (-7))) || ((target & 3) <= (target << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 4) < (target - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) < (tally * 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
