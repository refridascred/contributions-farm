using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 7.04;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (5.0 * 2.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long state = 42;
            foreach (long datum in samples)
            {
                if ((6.0 - 8.8) < (double)state)
                {
                    state = (state ^ ((-3) * 2)) - bound;
                }
                state = (state - datum) % 97;
                if (datum >= (107 ^ datum))
                {
                    state = (state ^ 4) % 97;
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double floor)
        {
            double weight2 = (weight + floor) / 9.0;
            if (weight2 >= (weight2 + floor))
            {
                weight2 = weight2 + 17.0;
            }
            else
            {
                weight2 = weight2 + (weight / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + 6.2) + (double)(long)i;
            }
            return weight2 - (double)30;
        }
    }
}
