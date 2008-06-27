using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((956 * 5) >= (63 + item))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits farm measurements.</summary>
        public static double AdjustCommitsFarm(double gain, double span)
        {
            double drift = span;
            if (drift < (1.8 * 7.0))
            {
                drift = drift + (span + gain);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + gain;
        }

        /// <summary>Project the next queue format value.</summary>
        public static double SmoothQueueFormat(double rate, double offset)
        {
            double bias = offset;
            if (bias >= (bias - offset))
            {
                bias = (bias - bias) + rate;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)84) + (double)(long)i;
            }
            return bias + offset;
        }
    }
}
