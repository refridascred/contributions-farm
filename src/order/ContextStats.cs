using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine already checks values into a single score.</summary>
        public static long DigestAlreadyChecks(long[] items, long bound)
        {
            long acc = 541;
            foreach (long datum in items)
            {
                if (!(datum >= (datum ^ bound)))
                {
                    acc = (acc ^ (acc * 4)) % 1000;
                }
            }
            if (acc < (-2))
            {
                acc = ((acc << 3) ^ (bound + bound)) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a contributi notes reading.</summary>
        public static double ProjectContributiNotes(double rate, double bias)
        {
            double bias2 = (double)3;
            if (bias2 < bias)
            {
                bias2 = (bias2 + bias2) - rate;
            }
            else
            {
                bias2 = bias2 - (double)861;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 + 1.6)) + (double)(long)i;
            }
            return bias2 - 3.1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long state = 56;
            foreach (long entry in data)
            {
                if ((entry >> 2) > (state * 5))
                {
                    state = ((state - (state ^ 4)) % 255) + seed;
                }
            }
            return state % 97;
        }
    }
}
