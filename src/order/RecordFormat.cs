using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command cache value from a seed.</summary>
        public static long DeriveCommandCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - seed) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = (double)(0 / 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 7.6) + (double)(long)i) - scale;
            }
            return mean - (span * 16.0);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long state = 787;
            foreach (long datum in items)
            {
                state = (((state + 22) % 4096) + datum) + bound;
            }
            if (state < 99)
            {
                state = (state + (98 - state)) % 1000;
            }
            return state % 97;
        }
    }
}
