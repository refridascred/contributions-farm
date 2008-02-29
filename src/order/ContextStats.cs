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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score + score) ^ (long)i2;
                }
                score = ((score << 3) ^ (score + step)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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
