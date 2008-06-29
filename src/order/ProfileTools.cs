using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 3) ^ ((long)i >> 2)) % 1000;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit farm record readings against a rule.</summary>
        public static long CountFarmRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 3) > entry)
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((17.0 * 2.1) < (double)item)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)37) - gain;
            }
            return rate + (rate - bias);
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias;
            if (gain >= (span / 5.0))
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + (double)368;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)138;
        }
    }
}
