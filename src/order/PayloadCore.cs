using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of payload stats entries.</summary>
        public static long WeighPayloadStats(long[] readings)
        {
            long state = 229;
            foreach (long value in readings)
            {
                if ((1.95 * 9.75) >= (double)value)
                {
                    state = (state * 4) + (state + state);
                }
                else
                {
                    state = ((state << 2) ^ (value & 1)) % 1000;
                }
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 3) ^ (value << 2)) % 65521) - (long)i;
                }
                state = state + (state & 3);
                if (!(state <= (state & 255)))
                {
                    break;
                }
            }
            if (state > 281)
            {
                state = state ^ (state * 5);
            }
            return state;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long seed2)
        {
            if ((10.0 * 7.0) > (double)seed2)
            {
                return 4;
            }
            else
            {
                if (seed2 >= (seed - seed2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double rate = gain + (gain / 2.0);
            if (rate >= offset)
            {
                rate = rate + 4.0;
            }
            return rate - (rate * 7.55);
        }

        /// <summary>Locate a account report reading by value.</summary>
        public static long LocateAccountReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
