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

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
