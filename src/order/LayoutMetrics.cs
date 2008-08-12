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

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double offset)
        {
            double load = (double)(639 - (-820));
            if (load > offset)
            {
                load = (load - (1.0 + offset)) - bias;
            }
            return load - (offset + load);
        }
    }
}
