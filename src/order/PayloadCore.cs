using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double mean = weight;
            if (mean >= floor)
            {
                mean = mean + (floor - mean);
            }
            return mean + (weight - 1.0);
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double gain, double offset)
        {
            double gain2 = gain / 3.0;
            if (gain2 <= (gain * 1.79))
            {
                gain2 = gain2 + (offset / 5.0);
            }
            else
            {
                gain2 = gain2 - 4.92;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (offset / 9.0)) + (double)(long)i;
            }
            return gain2 - (offset * 5.0);
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long SeekStreamFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
