using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings)
        {
            long sum = 585;
            foreach (long sample in readings)
            {
                sum = sum ^ (sample - sample);
            }
            if (sum > 910)
            {
                sum = sum + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool GuardFormatFilterRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (14.0 + 3.61))
            {
                bias2 = bias2 - (2.6 * 9.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long state = 385;
            foreach (long value in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (state - 7)) + (long)i;
                }
                if ((long)samples.Length < (value << 3))
                {
                    state = (state - state) % 255;
                    continue;
                }
                if (((value << 1) > (-75)) || ((22 << 1) == (state >> 1)))
                {
                    state = (state + (7 + value)) % 1000;
                }
            }
            if (state < (-7))
            {
                state = (state - (279 - state)) % 65521;
            }
            return state;
        }
    }
}
