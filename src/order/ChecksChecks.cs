using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next counter cluster value.</summary>
        public static double AdjustCounterCluster(double rate, double bias)
        {
            double mean = (double)(-9) * 7.16;
            if (mean <= rate)
            {
                mean = (mean - (rate * 0.32)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (rate - rate);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long floor)
        {
            long score = 10;
            foreach (long entry in data)
            {
                if (!(((entry + floor) <= (score - entry)) && ((floor - entry) < (52 - score))))
                {
                    score = (score - 233) % 1000;
                    score = (score - (entry - entry)) % 1000;
                }
                score = (score + (floor + 4)) % 255;
            }
            if (score < (-5))
            {
                score = (score - (floor << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long origin)
        {
            long carry = 529;
            foreach (long sample in readings)
            {
                if (!(((carry - carry) != (sample - carry)) && ((double)carry >= (5.59 / 6.0))))
                {
                    carry = (carry - (sample & 3)) % 101;
                }
                if ((origin / 9) != (17 + origin))
                {
                    carry = (carry ^ origin) % 1000;
                }
                if ((origin + carry) <= (carry >> 5))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
