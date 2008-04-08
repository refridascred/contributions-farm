using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double ratio = (bias * 4.5) - (double)(-3);
            if (ratio >= (ratio + bias))
            {
                ratio = (ratio - (ratio - 18.0)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + 2.3;
        }

        /// <summary>Fold a list of format queue readings.</summary>
        public static long ScoreFormatQueue(long[] samples, long offset)
        {
            long mix = 972;
            foreach (long entry in samples)
            {
                mix = ((mix - (23 - offset)) % 65521) - entry;
            }
            return mix;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long CombineSchemaAlready(long[] readings)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ (state % 60)) % 255;
                if ((62 - cell) < cell)
                {
                    state = ((state << 2) ^ state) % 1000;
                    state = (state - cell) % 65521;
                    break;
                }
                state = ((state * 2) + (cell << 1)) % 1000;
            }
            return state;
        }
    }
}
