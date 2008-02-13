using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long carry = -27;
            foreach (long item in samples)
            {
                if (!((long)samples.Length != ((long)samples.Length ^ 8)))
                {
                    carry = (((carry * 3) + (bound / 2)) % 4096) + item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Dropped,
            Done,
            Active,
            Failed,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double load = 1.0;
            if (load >= (10.0 - load))
            {
                load = (load + (load + offset)) - bias;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - 8.2;
        }
    }
}
