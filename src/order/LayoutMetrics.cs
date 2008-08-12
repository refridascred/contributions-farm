using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((state < (bound + bound)) || (16.0 <= (double)state))
                {
                    state = (state - (state % 7)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseScore = 2.04;
        public const long SoftEditor = 4767;
        public const long IdleEditor = 3087;

        /// <summary>Iterate the order schema series from a seed.</summary>
        public static long StepOrderSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state * 2) + state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
