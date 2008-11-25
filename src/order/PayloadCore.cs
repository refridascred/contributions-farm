using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile cache counter forward.</summary>
        public static long StepProfileCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double gain = 5.0 + (double)67;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + scale) + (double)(long)i) + floor;
            }
            return gain - (scale / 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8269;
        public const long MinBuffer = 9754;
        public const long IdleBuffer = 1716;
        public const double RetryBuffer = 74.87;
        public const long HardSpan = 2363;
    }
}
