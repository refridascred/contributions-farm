using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double bias2 = (double)(3 - (-13));
            if (bias2 < (bias * 4.78))
            {
                bias2 = bias2 + (rate / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (5.0 + bias2);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= (double)69)
            {
                gain2 = gain2 - (bias - gain2);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (bias * 20.0)) + (double)(long)i;
            }
            return gain2 - (double)8;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (9.22 > (double)(long)samples.Length)
                {
                    seen = ((seen + 1) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
