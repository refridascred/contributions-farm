using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next checks commits value.</summary>
        public static double SmoothChecksCommits(double rate, double offset)
        {
            double scale = 8.85;
            if (scale <= scale)
            {
                scale = (scale + (offset / 2.0)) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            if (((floor << 1) == (target & 7)) && ((9.7 * 8.6) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if (4.31 < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (drift + bias))
            {
                drift = drift - (ratio - 7.12);
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)40;
        }
    }
}
